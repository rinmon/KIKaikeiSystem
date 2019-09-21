using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.models.constants
{
    //マスタテーブルの値をコードに直接埋め込む場合、このファイル中で宣言した定数を使うこと
    //基本はマスタテーブルの値をコードに埋め込まない。必要最小限にする


    //貸借対象項目
    enum MTTaisyakuTaisyouKoumokuId {
        Shisan = 1,         // 資産
        Husai = 2,          // 負債
        Junshisan = 3,      // 純資産
    }

    //事業活動収支項目
    enum MTJigyoukatsudouSyuushiKoumoku {
        JigyoukatsudouSyuunyuu = 1,             // 事業活動収入
        JigyoukatsudouShisyutsu = 2,            // 事業活動支出
        JigyoukatsudougaiSyuunyuu = 3,          // 事業活動外収入
        JigyoukatsudougaiShisyutsu = 4,         // 事業活動外支出
        TokubetsuSyuunyuu = 5,                  // 特別収入
        TokubetsuShisyutsu = 6,                 // 特別支出
        KurikoshikatsudouSyuushiSagaku = 7      // 繰越活動収支差額
    }

    // 資金収支項目
    enum MTShikinSyuushiKoumoku {
        KeijouKatsudouSyuunyuu = 1,             // 経常活動収入
        KeijouKatsudouShisyutsu = 2,            // 経常活動支出
        ShisetsuSetsubiSyuunyuu = 3,            // 施設設備収入
        ShisetsuSetsubiShisyutsu = 4,           // 施設設備支出
        ZaimuSyuunyuu = 5,                      // 財務収入
        ZaimuShisyutsu = 6,                     // 財務支出
    }

    //大区分ID
    enum MTDaikubunId {
        KihonkinTorikuzushigaku = 47,               // 基本金取崩額
        KihonkinKumiiregaku2 = 48,                  // 基本金組み入れ額2
        SonotaTumitatekinTorikuzushigaku = 49,      // その他の積立金取り崩し額
        SonotaTumitatekinTumitategaku = 50,         // その他の積立金積立額
        JikiKurikoshikatsudouSyuushiSagaku = 59,    // 次期繰越活動収支差額
    }

    //大区分コード
    enum MTDaikubunCode {
        KoteiShisanKihonZaisan = 102,               // 固定資産（基本財産）
        JikiKurikoshikatsudouSyuushiSagaku = 116,   // 次期繰越活動収支差額
    }



    // MT会計単位
    enum MTKaikeiTanni {
        Hukushi = 1,    // 福祉
        Koueki = 2,     // 公益
        Syuueki = 3,    // 収益
    }

    // MT取引区分
    enum MTTorihikiKubun {
        Shikin = 1,     // 資金
        Jigyou = 2,     // 事業
//        Sonota = 3,     // その他  (2014.01.31その他は削除)
    }

    //MT法人施設ID
    enum MTHoujinShisetsuId {
        All = 99,
    }

    // 予算区分
    enum MTYosanKubun {
        TuujouYosan = 1,       // 通常予算
        HoseiYosan = 2,         // 補正予算
    }

    // 償却方法
    enum MTSyoukyakuHouhou {
        Teigakuhou = 1,             // 定額法
        Teiritsuhou = 2,            // 定率法
        Kintousyoukyakuhou = 3,     // 均等償却法
    }

    // 償却可非
    enum MTSyoukyakuKahi {
        SyousyakuKa = 1,        // 償却可
        SyoukyakuHuka = 2,      // 償却不可
    }


    // MT貸借区分
    enum MTTaisyakuKubun {
        KashiPlus = 1,      // 貸+
        KariPlus = 2,       // 借+
        KashiMinus = 3,     // 貸-
        KariMinus = 4,      // 借-
    }

    // MT担保区分
    enum MTTanpoKubun {
        TanpoShisan,        // 担保に供されている資産の種類および金額
        TanpoSaimu,         // 担保している債務の種類および金額
    }

    // MT科目区分
    enum MTKamokuKubun {
        Root = 1,                   // ルート
        JigyouRoot = 2,             // 事業ルート
        TaisyakuRoot = 3,           // 貸借ルート
        ShikinRoot = 4,             // 資金ルート
        JigyouSyuunyuu = 9,         // 事業活動による収入
        JigyouShisyutsu = 262,      // 事業活動による支出
        ShisetsuSyuunyuu = 419,     // 施設設備等による収入
        ShisetsuShisyutsu = 453,    // 施設設備等による支出
        SonotaSyuunyuu = 459,       // その他の活動による収入
        SonotaShisyutsu = 673,      // その他の活動による支出
        ServiceKatsudouZougenSyuueki = 5,       // サービス活動増減による収益
        ServiceKatsudouZougenHiyou = 259,       // サービス活動増減による費用
        ServiceKatsudouGaiZougenSyuueki = 399,  // サービス活動外増減による収益
        ServiceKatsudouGaiZougenHiyou = 432,    // サービス活動外増減による費用
        TokubetsuZougenSyuueki = 456,           // 特別増減による収益
        TokubetsuZougenHiyou = 498,             // 特別増減による費用
        KurikoshiKatsudouZougenSagaku = 529,    // 繰越活動増減差額
        Shisan = 542,               // 資産
        Husai = 606,                // 負債
        Junshisan = 644,            // 純資産

        RyuudouShisan = 543,        // 流動資産
        RyuudouHusai = 607,         // 流動負債

        KoteiShisanKihonZaisan = 574,   // 固定資産（基本財産)
        KoteiShisanSonota = 579,        // 固定資産（その他の固定資産）
        JikiKurikoshikatsudouZougenSagakuDaikubun = 654, //次期繰越活動増減差額（大区分)
        JikiKurikoshikatsudouZougenSagakuChukubun = 655, //次期繰越活動増減差額（中区分)
        Syokuchi = 656,             // 諸口
        ShiharaiShikin = 734,       // 支払資金
        ZenkimatsuShiharaiShikinZandaka = 10000, // 前期末支払資金残高
        ReservedMax = 745,          // 予約されている科目IDの最大

        KihonkinTorikuzushiGakuDaikubun = 530, // 基本金取崩額（大区分）
        KihonkinTorikuzushiGakuChukubun = 531, // 基本金取崩額（中区分）

        SonotaTsumitatekinTorikuzushiGaku = 532,    // その他の積立金取崩額
        SonotaTsumitatekinTsumitateGaku = 537,      // その他の積立金積立額

        // その他の固定資産（有形）
        SonotaKoteiShisanYuukeiStart = 580,
        SonotaKoteiShisanTochi = 580,
        SonotaKoteiShisanTatemono = 581,
        SonotaKoteiShisanKenchikubutsu = 582,
        SonotaKoteiShisanKikaiSouchi = 583,
        SonotaKoteiShisanSyaryou = 584,
        SonotaKoteiShisanKiguBihin = 585,
        SonotaKoteiShisanKensetsuKariKanjou = 586,
        SonotaKoteiShisanYuukeiLease = 587,
        SonotaKoteiShisanYuukeiEnd = 587,

        //引当金
        TyousyuuHunouHikiatekin = 573,
        SyouyoHikiatekin = 631,
        TaisyokuKyuuhuHikiatekin = 640,
    }


    // MT勘定科目
    enum MTKanjouKamoku {
        JikiKurikoshikatsudouZougenSagaku = 339,    //次期繰越活動増減差額
        Syokuchi = 340,                             //諸口
        ShiharaiShikin = 392,                       //支払資金
        ZenkimatsuShiharaiShikinZandaka = 10000,    // 前期末支払資金残高
        GenkaSyoukyakuhi = 175,                     // 減価償却費
    }


    // MT会計区分のhierarchy
    enum MTKaikeiKubunHierarchy {
        Houjin = 1,
        Jigyou = 2,
        Kyoten = 3,
        Service = 4
    }


    // MT勘定科目のhierarchy
    enum MTKanjouKamokuHierarchy {
        ChuuKubun = 1,          // 中区分
        SyouKubun = 2,          // 小区分
        HojoKamoku = 3,          // 補助科目
    }


    // MT科目区分のhierarchy
    enum MTKamokuKubunHierarchy {
        Root = 0,                   // ルート
        KubunRoot = 1,              // 区分タイプ (事業 or 貸借 or 資金)
        Kubun = 2,                  // 区分
        Daikubun = 3,               // 大区分
        ChuuKubun = 4,              // 中区分
        SyouKubun = 5,              // 小区分
        HojoKamoku = 6,             // 補助科目
    }
}
