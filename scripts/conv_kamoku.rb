#!/usr/bin/ruby
# -*- coding: cp932 -*-


#kamoku_file = open("kamoku.sql", "w")
#kubun_file = open("kubun.sql", "w")

taisyaku_hash = {}
taisyaku_hash['貸+'] = 1
taisyaku_hash['借+'] = 2
taisyaku_hash['貸-'] = 3
taisyaku_hash['借-'] = 4

enable_hash = {}
enable_hash['不可'] = 0
enable_hash['可'] = 1

kamoku_type = Struct.new("KamokuType", :caption, :index, :code, :taisyaku, :usable, :editable)
kubun_type = Struct.new("KubunType", :caption, :index)

before_kamoku = nil
before_kamoku_id = 0

before_jigyou = Array.new(5).map{kubun_type.new("", -1)}
before_taisyaku = Array.new(5).map{kubun_type.new("", -1)}
before_shikin = Array.new(5).map{kubun_type.new("", -1)}
before_kubun = [before_jigyou, before_taisyaku, before_shikin]
kubun_id_hash = Hash.new

puts "insert into mt_kamoku_kubun(id, name, has_child, parent_id, hide_in_summary) values(1, 'root', 1, -1, 0);"
puts "insert into mt_kamoku_kubun(id, name, has_child, parent_id, hide_in_summary) values(2, 'jigyou_root', 1, 1, 0);"
puts "insert into mt_kamoku_kubun(id, name, has_child, parent_id, hide_in_summary) values(3, 'taisyaku_root', 1, 1, 0);"
puts "insert into mt_kamoku_kubun(id, name, has_child, parent_id, hide_in_summary) values(4, 'shikin_root', 1, 1, 0);"

before_kubun_id = 4


def print_kubun(kubun, has_child, parent_id)
  puts "insert into mt_kamoku_kubun(id, name, has_child, parent_id, hide_in_summary) values(#{kubun.index}, '#{kubun.caption}', #{has_child}, #{parent_id}, 0);"
end

def print_kamoku(kamoku, has_child, parent_id, kubun, kubun_level)
  puts "insert into mt_kanjou_kamoku(id, kamoku, kamoku_yomi, has_child," +
    "parent_id, shikin_kamoku_kubun_id, jigyou_kamoku_kubun_id, taisyaku_kamoku_kubun_id, " +
    "taisyaku_kubun_id, usable, editable, kamoku_code ) values(" +
    "#{kamoku.index}, '#{kamoku.caption}', '', #{has_child}, #{parent_id}, #{kubun[2][kubun_level].index}, " +
    "#{kubun[0][kubun_level].index}, #{kubun[1][kubun_level].index}, #{kamoku.taisyaku}, #{kamoku.usable}, #{kamoku.editable}, '#{kamoku.code}');"
end


def kubun_key(kubun_array, index)
  str = ""
  (0..index).each do |i|
    str += kubun_array[i].caption + "_"
  end
  return str
end


hojo_id = 1


STDIN.each do |line|
  tokens = line.chop.split("\t", -1)
  kamoku_code = tokens[4]
  kamoku_name = tokens[5]
  taisyaku = taisyaku_hash[tokens[6]]
  usable = enable_hash[tokens[7]]
  editable = enable_hash[tokens[8]]
  
  jigyou_kubun = tokens[9..13].map{|v| kubun_type.new(v, nil)}
  taisyaku_kubun = tokens[14..18].map{|v| kubun_type.new(v, nil)}
  shikin_kubun = tokens[19..23].map{|v| kubun_type.new(v, nil)}

  kubun = [jigyou_kubun, taisyaku_kubun, shikin_kubun]

  has_hojo_kamoku = 0
  has_hojo_kamoku = 1 if jigyou_kubun[3].caption.length > 0 or taisyaku_kubun[3].caption.length > 0 or shikin_kubun[3].caption.length > 0

  # 区分
  kubun.each_index do |i|
    kubun[i].each_index do |j|
      if kamoku_code.length > 0 or kubun[i][j].caption.length > 0 then
        before_kubun[i][j].caption = kubun[i][j].caption
        if kubun[i][j].caption.length > 0 then
          id = kubun_id_hash[kubun_key(before_kubun[i], j)]
          if id != nil then
            before_kubun[i][j].index = id
          else
            before_kubun_id += 1
            before_kubun[i][j].index = before_kubun_id
            
            has_child = 0
            has_child = 1 if j < kubun[i].size - 1 and kubun[i][j + 1].caption.length > 0
            parent_id = i + 2
            parent_id = before_kubun[i][j - 1].index if j >= 1
            
            print_kubun(before_kubun[i][j], has_child, parent_id)

            kubun_id_hash[kubun_key(before_kubun[i], j)] = before_kubun[i][j].index
          end
        else
          before_kubun[i][j].index = -1
        end
      end
    end
  end

  if kamoku_code.length > 0 then	# 科目
    before_kamoku_id += 1
    before_kamoku = kamoku_type.new(kamoku_name, before_kamoku_id, kamoku_code, taisyaku, usable, editable)
    print_kamoku(before_kamoku, has_hojo_kamoku, -1, before_kubun, 2)

    hojo_id = 1
  end

  if has_hojo_kamoku == 1 then
    caption = ""
    if jigyou_kubun[3].caption.length > 0 then
      caption = jigyou_kubun[3].caption
    elsif shikin_kubun[3].caption.length > 0 then
      caption = shikin_kubun[3].caption
    elsif taisyaku_kubun[3].caption.length > 0 then
      caption = taisyaku_kubun[3].caption
    end

    before_kamoku_id += 1
    before_hojo_kamoku = kamoku_type.new(caption, before_kamoku_id, hojo_id.to_s, before_kamoku.taisyaku, before_kamoku.usable, before_kamoku.editable)
    print_kamoku(before_hojo_kamoku, 0, before_kamoku.index, before_kubun, 3)

    hojo_id += 1
  end
end

