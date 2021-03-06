﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    public partial class GoogleAlertAPI
    {
        public class Alert
        {
            public string id;
            public string query;
            public HowOften howOften = HowOften.AtMostOnceADay;
            public List<Sources> sources = new List<Sources>();
            public Language language = Language.AnyLanguage;
            public Region region = Region.AnyRegion;
            public HowMany howMany = HowMany.OnlyTheBestResults;
            public DeliveryTo deliveryTo = DeliveryTo.Email;
            public string feedUrl;
            public override string ToString()
            {
                var sources_text = string.Empty;
                if (sources != null)
                {
                    foreach (var source in sources)
                    {
                        sources_text += source + ",";
                    }
                }
                return "[ID:" + id + " Query:" + query + " HowOften:" + howOften + " Sources:" + sources_text + " Language:" + language + " Region:" + region + " HowMany:" + howMany + " deliveryTo:" + deliveryTo + " feedUrl:" + feedUrl + "]";
            }
        }

        public enum DeliveryTo
        {
            Email,
            Feed
        }

        public enum HowMany
        {
            OnlyTheBestResults = 3,
            AllResults = 2
        }

        public enum HowOften
        {
            AsItHappens = 1,
            AtMostOnceADay = 2,
            AtMostOnceAWeek = 3
        }

        public enum Sources
        {
            [Description("")]
            Automatic,
            [Description("2")]
            News,
            [Description("1")]
            Blogs,
            [Description("3")]
            Web,
            [Description("5")]
            Video,
            [Description("6")]
            Books,
            [Description("7")]
            Discussions,
            [Description("8")]
            Finance
        }

        public enum Language
        {
            [Description("")]
            AnyLanguage,
            [Description("af")]
            Afrikaans,
            [Description("ar")]
            Arabic,
            [Description("hy")]
            Armenian,
            [Description("be")]
            Belarusian,
            [Description("bg")]
            Bulgarian,
            [Description("ca")]
            Catalan,
            [Description("zh-CN")]
            ChineseSimplified,
            [Description("zh-TW")]
            ChineseTraditional,
            [Description("hr")]
            Croatian,
            [Description("cs")]
            Czech,
            [Description("da")]
            Danish,
            [Description("nl")]
            Dutch,
            [Description("en")]
            English,
            [Description("eo")]
            Esperanto,
            [Description("et")]
            Estonian,
            [Description("fil")]
            Filipino,
            [Description("fi")]
            Finnish,
            [Description("fr")]
            French,
            [Description("de")]
            German,
            [Description("el")]
            Greek,
            [Description("iw")]
            Hebrew,
            [Description("hi")]
            Hindi,
            [Description("hu")]
            Hungarian,
            [Description("is")]
            Icelandic,
            [Description("id")]
            Indonesian,
            [Description("it")]
            Italian,
            [Description("ja")]
            Japanese,
            [Description("ko")]
            Korean,
            [Description("lv")]
            Latvian,
            [Description("lt")]
            Lithuanian,
            [Description("no")]
            Norwegian,
            [Description("fa")]
            Persian,
            [Description("pl")]
            Polish,
            [Description("pt-PT")]
            Portuguese,
            [Description("ro")]
            Romanian,
            [Description("ru")]
            Russian,
            [Description("sr")]
            Serbian,
            [Description("sk")]
            Slovak,
            [Description("sl")]
            Slovenian,
            [Description("es")]
            Spanish,
            [Description("sw")]
            Swahili,
            [Description("sv")]
            Swedish,
            [Description("th")]
            Thai,
            [Description("tr")]
            Turkish,
            [Description("uk")]
            Ukrainian,
            [Description("vi")]
            Vietnamese,
        }

        public enum Region
        {
            [Description("")]
            AnyRegion,
            [Description("AF")]
            Afghanistan,
            [Description("AL")]
            Albania,
            [Description("DZ")]
            Algeria,
            [Description("AS")]
            American_Samoa,
            [Description("AD")]
            Andorra,
            [Description("AO")]
            Angola,
            [Description("AI")]
            Anguilla,
            [Description("AQ")]
            Antarctica,
            [Description("AG")]
            AntiguaAndBarbuda,
            [Description("AR")]
            Argentina,
            [Description("AM")]
            Armenia,
            [Description("AW")]
            Aruba,
            [Description("AU")]
            Australia,
            [Description("AT")]
            Austria,
            [Description("AZ")]
            Azerbaijan,
            [Description("BS")]
            Bahamas,
            [Description("BH")]
            Bahrain,
            [Description("BD")]
            Bangladesh,
            [Description("BB")]
            Barbados,
            [Description("BY")]
            Belarus,
            [Description("BE")]
            Belgium,
            [Description("BZ")]
            Belize,
            [Description("BJ")]
            Benin,
            [Description("BM")]
            Bermuda,
            [Description("BT")]
            Bhutan,
            [Description("BO")]
            Bolivia,
            [Description("BA")]
            BosniaAndHerzegovina,
            [Description("BW")]
            Botswana,
            [Description("BV")]
            BouvetIsland,
            [Description("BR")]
            Brazil,
            [Description("IO")]
            BritishIndianOceanTerritory,
            [Description("VG")]
            BritishVirginIslands,
            [Description("BN")]
            Brunei,
            [Description("BG")]
            Bulgaria,
            [Description("BF")]
            BurkinaFaso,
            [Description("BI")]
            Burundi,
            [Description("KH")]
            Cambodia,
            [Description("CM")]
            Cameroon,
            [Description("CA")]
            Canada,
            [Description("CV")]
            CapeVerde,
            [Description("KY")]
            CaymanIslands,
            [Description("CF")]
            CentralAfricanRepublic,
            [Description("TD")]
            Chad,
            [Description("CL")]
            Chile,
            [Description("CN")]
            China,
            [Description("CX")]
            ChristmasIsland,
            [Description("CC")]
            CocosKeelingIslands,
            [Description("CO")]
            Colombia,
            [Description("KM")]
            Comoros,
            [Description("CD")]
            CongoDRC,
            [Description("CK")]
            CookIslands,
            [Description("CR")]
            CostaRica,
            [Description("CI")]
            CoteDIvoire,
            [Description("HR")]
            Croatia,
            [Description("CU")]
            Cuba,
            [Description("CY")]
            Cyprus,
            [Description("CZ")]
            CzechRepublic,
            [Description("DK")]
            Denmark,
            [Description("DJ")]
            Djibouti,
            [Description("DM")]
            Dominica,
            [Description("DO")]
            DominicanRepublic,
            [Description("EC")]
            Ecuador,
            [Description("EG")]
            Egypt,
            [Description("SV")]
            ElSalvador,
            [Description("GQ")]
            EquatorialGuinea,
            [Description("ER")]
            Eritrea,
            [Description("EE")]
            Estonia,
            [Description("ET")]
            Ethiopia,
            [Description("EU")]
            EuropeanUnion,
            [Description("FK")]
            FalklandIslandsIslasMalvinas,
            [Description("FO")]
            FaroeIslands,
            [Description("FJ")]
            Fiji,
            [Description("FI")]
            Finland,
            [Description("FR")]
            France,
            [Description("GF")]
            FrenchGuiana,
            [Description("PF")]
            FrenchPolynesia,
            [Description("TF")]
            FrenchSouthernTerritories,
            [Description("GA")]
            Gabon,
            [Description("GM")]
            Gambia,
            [Description("GE")]
            Georgia,
            [Description("DE")]
            Germany,
            [Description("GH")]
            Ghana,
            [Description("GI")]
            Gibraltar,
            [Description("GR")]
            Greece,
            [Description("GL")]
            Greenland,
            [Description("GD")]
            Grenada,
            [Description("GP")]
            Guadeloupe,
            [Description("GU")]
            Guam,
            [Description("GT")]
            Guatemala,
            [Description("GN")]
            Guinea,
            [Description("GW")]
            GuineaBissau,
            [Description("GY")]
            Guyana,
            [Description("HT")]
            Haiti,
            [Description("HM")]
            HeardAndMcDonaldIslands,
            [Description("HN")]
            Honduras,
            [Description("HK")]
            HongKong,
            [Description("HU")]
            Hungary,
            [Description("IS")]
            Iceland,
            [Description("IN")]
            India,
            [Description("ID")]
            Indonesia,
            [Description("IR")]
            Iran,
            [Description("IQ")]
            Iraq,
            [Description("IE")]
            Ireland,
            [Description("IL")]
            Israel,
            [Description("IT")]
            Italy,
            [Description("JM")]
            Jamaica,
            [Description("JP")]
            Japan,
            [Description("JO")]
            Jordan,
            [Description("KZ")]
            Kazakhstan,
            [Description("KE")]
            Kenya,
            [Description("KI")]
            Kiribati,
            [Description("KW")]
            Kuwait,
            [Description("KG")]
            Kyrgyzstan,
            [Description("LA")]
            Laos,
            [Description("LV")]
            Latvia,
            [Description("LB")]
            Lebanon,
            [Description("LS")]
            Lesotho,
            [Description("LR")]
            Liberia,
            [Description("LY")]
            Libya,
            [Description("LI")]
            Liechtenstein,
            [Description("LT")]
            Lithuania,
            [Description("LU")]
            Luxembourg,
            [Description("MO")]
            Macau,
            [Description("MK")]
            MacedoniaFYROM,
            [Description("MG")]
            Madagascar,
            [Description("MW")]
            Malawi,
            [Description("MY")]
            Malaysia,
            [Description("MV")]
            Maldives,
            [Description("ML")]
            Mali,
            [Description("MT")]
            Malta,
            [Description("MH")]
            Marshall_Islands,
            [Description("MQ")]
            Martinique,
            [Description("MR")]
            Mauritania,
            [Description("MU")]
            Mauritius,
            [Description("YT")]
            Mayotte,
            [Description("MX")]
            Mexico,
            [Description("FM")]
            Micronesia,
            [Description("MD")]
            Moldova,
            [Description("MC")]
            Monaco,
            [Description("MN")]
            Mongolia,
            [Description("MS")]
            Montserrat,
            [Description("MA")]
            Morocco,
            [Description("MZ")]
            Mozambique,
            [Description("MM")]
            MyanmarBurma,
            [Description("NA")]
            Namibia,
            [Description("NR")]
            Nauru,
            [Description("NP")]
            Nepal,
            [Description("NL")]
            Netherlands,
            [Description("AN")]
            NetherlandsAntilles,
            [Description("NC")]
            NewCaledonia,
            [Description("NZ")]
            NewZealand,
            [Description("NI")]
            Nicaragua,
            [Description("NE")]
            Niger,
            [Description("NG")]
            Nigeria,
            [Description("NU")]
            Niue,
            [Description("NF")]
            NorfolkIsland,
            [Description("KP")]
            NorthKorea,
            [Description("MP")]
            NorthernMarianaIslands,
            [Description("NO")]
            Norway,
            [Description("OM")]
            Oman,
            [Description("PK")]
            Pakistan,
            [Description("PW")]
            Palau,
            [Description("PS")]
            Palestine,
            [Description("PA")]
            Panama,
            [Description("PG")]
            PapuaNewGuinea,
            [Description("PY")]
            Paraguay,
            [Description("PE")]
            Peru,
            [Description("PH")]
            Philippines,
            [Description("PN")]
            PitcairnIslands,
            [Description("PL")]
            Poland,
            [Description("PT")]
            Portugal,
            [Description("PR")]
            PuertoRico,
            [Description("QA")]
            Qatar,
            [Description("RE")]
            Runion,
            [Description("RO")]
            Romania,
            [Description("RU")]
            Russia,
            [Description("RW")]
            Rwanda,
            [Description("SH")]
            SaintHelena,
            [Description("KN")]
            SaintKittsAndNevis, 
            [Description("LC")]
            SaintLucia,
            [Description("PM")]
            SaintPierreAndMiquelon,
            [Description("WS")]
            Samoa,
            [Description("SM")]
            SanMarino,
            [Description("ST")]
            SaoTomeAndPrincipe,
            [Description("SA")]
            SaudiArabia,
            [Description("SN")]
            Senegal,
            [Description("RS")]
            SerbiaRS,
            [Description("YU")]
            SerbiaYU,
            [Description("SC")]
            Seychelles,
            [Description("SL")]
            Sierra_Leone,
            [Description("SG")]
            Singapore,
            [Description("SK")]
            Slovakia,
            [Description("SI")]
            Slovenia,
            [Description("SB")]
            SolomonIslands,
            [Description("SO")]
            Somalia,
            [Description("ZA")]
            South_Africa,
            [Description("GS")]
            SouthGeorgiaAndSouthSandwichIslands,
            [Description("KR")]
            SouthKorea,
            [Description("ES")]
            Spain,
            [Description("LK")]
            SriLanka,
            [Description("VC")]
            StVincentAndGrenadines,
            [Description("SD")]
            Sudan,
            [Description("SR")]
            Suriname,
            [Description("SJ")]
            SvalbardAndJanMayen,
            [Description("SZ")]
            Swaziland,
            [Description("SE")]
            Sweden,
            [Description("CH")]
            Switzerland,
            [Description("SY")]
            Syria,
            [Description("TW")]
            Taiwan,
            [Description("TJ")]
            Tajikistan,
            [Description("TZ")]
            Tanzania,
            [Description("TH")]
            Thailand,
            [Description("TP")]
            TimorLeste,
            [Description("TG")]
            Togo,
            [Description("TK")]
            Tokelau,
            [Description("TO")]
            Tonga,
            [Description("TT")]
            TrinidadAndTobago,
            [Description("TN")]
            Tunisia,
            [Description("TR")]
            Turkey,
            [Description("TM")]
            Turkmenistan,
            [Description("TC")]
            TurksAndCaicosIslands,
            [Description("TV")]
            Tuvalu,
            [Description("UM")]
            USOutlyingIslands,
            [Description("VI")]
            USVirginIslands,
            [Description("UG")]
            Uganda,
            [Description("UA")]
            Ukraine,
            [Description("AE")]
            UnitedArabEmirates,
            [Description("GB")]
            UnitedKingdom,
            [Description("US")]
            UnitedStates,
            [Description("UY")]
            Uruguay,
            [Description("UZ")]
            Uzbekistan,
            [Description("VU")]
            Vanuatu,
            [Description("VA")]
            VaticanCity,
            [Description("VE")]
            Venezuela,
            [Description("VN")]
            Vietnam,
            [Description("WF")]
            WallisAndFutuna,
            [Description("EH")]
            WesternSahara,
            [Description("YE")]
            Yemen,
            [Description("ZM")]
            Zambia,
            [Description("ZW")]
            Zimbabwe
        }
    }
}
