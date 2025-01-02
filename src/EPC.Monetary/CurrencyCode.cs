namespace EPC.Monetary
{
    // https://en.wikipedia.org/wiki/ISO_4217
    /// <summary>
    /// Currency code as defined by ISO 4217
    /// </summary>
    public enum CurrencyCode
    {
        /* https://en.wikipedia.org/wiki/ISO_4217#Active_codes_(list_one)
        * Regex: (\w+) 	(\d+) 	[\d\.](?:\S+)? 	([\p{L} ]+\p{L}+).*$
        * Substitution: /// <summary>\n/// $3\n/// </summary>\n$1 = $2,\n
        */

        /// <summary>
        /// United Arab Emirates dirham
        /// </summary>
        AED = 784,

        /// <summary>
        /// Afghan afghani
        /// </summary>
        AFN = 971,

        /// <summary>
        /// Albanian lek
        /// </summary>
        ALL = 008,

        /// <summary>
        /// Armenian dram
        /// </summary>
        AMD = 051,

        /// <summary>
        /// Netherlands Antillean guilder
        /// </summary>
        ANG = 532,

        /// <summary>
        /// Angolan kwanza
        /// </summary>
        AOA = 973,

        /// <summary>
        /// Argentine peso
        /// </summary>
        ARS = 032,

        /// <summary>
        /// Australian dollar
        /// </summary>
        AUD = 036,

        /// <summary>
        /// Aruban florin
        /// </summary>
        AWG = 533,

        /// <summary>
        /// Azerbaijani manat
        /// </summary>
        AZN = 944,

        /// <summary>
        /// Bosnia and Herzegovina convertible mark
        /// </summary>
        BAM = 977,

        /// <summary>
        /// Barbados dollar
        /// </summary>
        BBD = 052,

        /// <summary>
        /// Bangladeshi taka
        /// </summary>
        BDT = 050,

        /// <summary>
        /// Bulgarian lev
        /// </summary>
        BGN = 975,

        /// <summary>
        /// Bahraini dinar
        /// </summary>
        BHD = 048,

        /// <summary>
        /// Burundian franc
        /// </summary>
        BIF = 108,

        /// <summary>
        /// Bermudian dollar
        /// </summary>
        BMD = 060,

        /// <summary>
        /// Brunei dollar
        /// </summary>
        BND = 096,

        /// <summary>
        /// Boliviano
        /// </summary>
        BOB = 068,

        /// <summary>
        /// Bolivian Mvdol
        /// </summary>
        BOV = 984,

        /// <summary>
        /// Brazilian real
        /// </summary>
        BRL = 986,

        /// <summary>
        /// Bahamian dollar
        /// </summary>
        BSD = 044,

        /// <summary>
        /// Bhutanese ngultrum
        /// </summary>
        BTN = 064,

        /// <summary>
        /// Botswana pula
        /// </summary>
        BWP = 072,

        /// <summary>
        /// Belarusian ruble
        /// </summary>
        BYN = 933,

        /// <summary>
        /// Belize dollar
        /// </summary>
        BZD = 084,

        /// <summary>
        /// Canadian dollar
        /// </summary>
        CAD = 124,

        /// <summary>
        /// Congolese franc
        /// </summary>
        CDF = 976,

        /// <summary>
        /// WIR euro
        /// </summary>
        CHE = 947,

        /// <summary>
        /// Swiss franc
        /// </summary>
        CHF = 756,

        /// <summary>
        /// WIR franc
        /// </summary>
        CHW = 948,

        /// <summary>
        /// Unidad de Fomento
        /// </summary>
        CLF = 990,

        /// <summary>
        /// Chilean peso
        /// </summary>
        CLP = 152,

        /// <summary>
        /// Renminbi
        /// </summary>
        CNY = 156,

        /// <summary>
        /// Colombian peso
        /// </summary>
        COP = 170,

        /// <summary>
        /// Unidad de Valor Real
        /// </summary>
        COU = 970,

        /// <summary>
        /// Costa Rican colon
        /// </summary>
        CRC = 188,

        /// <summary>
        /// Cuban peso
        /// </summary>
        CUP = 192,

        /// <summary>
        /// Cape Verdean escudo
        /// </summary>
        CVE = 132,

        /// <summary>
        /// Czech koruna
        /// </summary>
        CZK = 203,

        /// <summary>
        /// Djiboutian franc
        /// </summary>
        DJF = 262,

        /// <summary>
        /// Danish krone
        /// </summary>
        DKK = 208,

        /// <summary>
        /// Dominican peso
        /// </summary>
        DOP = 214,

        /// <summary>
        /// Algerian dinar
        /// </summary>
        DZD = 012,

        /// <summary>
        /// Egyptian pound
        /// </summary>
        EGP = 818,

        /// <summary>
        /// Eritrean nakfa
        /// </summary>
        ERN = 232,

        /// <summary>
        /// Ethiopian birr
        /// </summary>
        ETB = 230,

        /// <summary>
        /// Euro
        /// </summary>
        EUR = 978,

        /// <summary>
        /// Fiji dollar
        /// </summary>
        FJD = 242,

        /// <summary>
        /// Falkland Islands pound
        /// </summary>
        FKP = 238,

        /// <summary>
        /// Pound sterling
        /// </summary>
        GBP = 826,

        /// <summary>
        /// Georgian lari
        /// </summary>
        GEL = 981,

        /// <summary>
        /// Ghanaian cedi
        /// </summary>
        GHS = 936,

        /// <summary>
        /// Gibraltar pound
        /// </summary>
        GIP = 292,

        /// <summary>
        /// Gambian dalasi
        /// </summary>
        GMD = 270,

        /// <summary>
        /// Guinean franc
        /// </summary>
        GNF = 324,

        /// <summary>
        /// Guatemalan quetzal
        /// </summary>
        GTQ = 320,

        /// <summary>
        /// Guyanese dollar
        /// </summary>
        GYD = 328,

        /// <summary>
        /// Hong Kong dollar
        /// </summary>
        HKD = 344,

        /// <summary>
        /// Honduran lempira
        /// </summary>
        HNL = 340,

        /// <summary>
        /// Haitian gourde
        /// </summary>
        HTG = 332,

        /// <summary>
        /// Hungarian forint
        /// </summary>
        HUF = 348,

        /// <summary>
        /// Indonesian rupiah
        /// </summary>
        IDR = 360,

        /// <summary>
        /// Israeli new shekel
        /// </summary>
        ILS = 376,

        /// <summary>
        /// Indian rupee
        /// </summary>
        INR = 356,

        /// <summary>
        /// Iraqi dinar
        /// </summary>
        IQD = 368,

        /// <summary>
        /// Iranian rial
        /// </summary>
        IRR = 364,

        /// <summary>
        /// Icelandic króna
        /// </summary>
        ISK = 352,

        /// <summary>
        /// Jamaican dollar
        /// </summary>
        JMD = 388,

        /// <summary>
        /// Jordanian dinar
        /// </summary>
        JOD = 400,

        /// <summary>
        /// Japanese yen
        /// </summary>
        JPY = 392,

        /// <summary>
        /// Kenyan shilling
        /// </summary>
        KES = 404,

        /// <summary>
        /// Kyrgyzstani som
        /// </summary>
        KGS = 417,

        /// <summary>
        /// Cambodian riel
        /// </summary>
        KHR = 116,

        /// <summary>
        /// Comoro franc
        /// </summary>
        KMF = 174,

        /// <summary>
        /// North Korean won
        /// </summary>
        KPW = 408,

        /// <summary>
        /// South Korean won
        /// </summary>
        KRW = 410,

        /// <summary>
        /// Kuwaiti dinar
        /// </summary>
        KWD = 414,

        /// <summary>
        /// Cayman Islands dollar
        /// </summary>
        KYD = 136,

        /// <summary>
        /// Kazakhstani tenge
        /// </summary>
        KZT = 398,

        /// <summary>
        /// Lao kip
        /// </summary>
        LAK = 418,

        /// <summary>
        /// Lebanese pound
        /// </summary>
        LBP = 422,

        /// <summary>
        /// Sri Lankan rupee
        /// </summary>
        LKR = 144,

        /// <summary>
        /// Liberian dollar
        /// </summary>
        LRD = 430,

        /// <summary>
        /// Lesotho loti
        /// </summary>
        LSL = 426,

        /// <summary>
        /// Libyan dinar
        /// </summary>
        LYD = 434,

        /// <summary>
        /// Moroccan dirham
        /// </summary>
        MAD = 504,

        /// <summary>
        /// Moldovan leu
        /// </summary>
        MDL = 498,

        /// <summary>
        /// Malagasy ariary
        /// </summary>
        MGA = 969,

        /// <summary>
        /// Macedonian denar
        /// </summary>
        MKD = 807,

        /// <summary>
        /// Myanmar kyat
        /// </summary>
        MMK = 104,

        /// <summary>
        /// Mongolian tögrög
        /// </summary>
        MNT = 496,

        /// <summary>
        /// Macanese pataca
        /// </summary>
        MOP = 446,

        /// <summary>
        /// Mauritanian ouguiya
        /// </summary>
        MRU = 929,

        /// <summary>
        /// Mauritian rupee
        /// </summary>
        MUR = 480,

        /// <summary>
        /// Maldivian rufiyaa
        /// </summary>
        MVR = 462,

        /// <summary>
        /// Malawian kwacha
        /// </summary>
        MWK = 454,

        /// <summary>
        /// Mexican peso
        /// </summary>
        MXN = 484,

        /// <summary>
        /// Mexican Unidad de Inversion
        /// </summary>
        MXV = 979,

        /// <summary>
        /// Malaysian ringgit
        /// </summary>
        MYR = 458,

        /// <summary>
        /// Mozambican metical
        /// </summary>
        MZN = 943,

        /// <summary>
        /// Namibian dollar
        /// </summary>
        NAD = 516,

        /// <summary>
        /// Nigerian naira
        /// </summary>
        NGN = 566,

        /// <summary>
        /// Nicaraguan córdoba
        /// </summary>
        NIO = 558,

        /// <summary>
        /// Norwegian krone
        /// </summary>
        NOK = 578,

        /// <summary>
        /// Nepalese rupee
        /// </summary>
        NPR = 524,

        /// <summary>
        /// New Zealand dollar
        /// </summary>
        NZD = 554,

        /// <summary>
        /// Omani rial
        /// </summary>
        OMR = 512,

        /// <summary>
        /// Panamanian balboa
        /// </summary>
        PAB = 590,

        /// <summary>
        /// Peruvian sol
        /// </summary>
        PEN = 604,

        /// <summary>
        /// Papua New Guinean kina
        /// </summary>
        PGK = 598,

        /// <summary>
        /// Philippine peso
        /// </summary>
        PHP = 608,

        /// <summary>
        /// Pakistani rupee
        /// </summary>
        PKR = 586,

        /// <summary>
        /// Polish złoty
        /// </summary>
        PLN = 985,

        /// <summary>
        /// Paraguayan guaraní
        /// </summary>
        PYG = 600,

        /// <summary>
        /// Qatari riyal
        /// </summary>
        QAR = 634,

        /// <summary>
        /// Romanian leu
        /// </summary>
        RON = 946,

        /// <summary>
        /// Serbian dinar
        /// </summary>
        RSD = 941,

        /// <summary>
        /// Russian ruble
        /// </summary>
        RUB = 643,

        /// <summary>
        /// Rwandan franc
        /// </summary>
        RWF = 646,

        /// <summary>
        /// Saudi riyal
        /// </summary>
        SAR = 682,

        /// <summary>
        /// Solomon Islands dollar
        /// </summary>
        SBD = 090,

        /// <summary>
        /// Seychelles rupee
        /// </summary>
        SCR = 690,

        /// <summary>
        /// Sudanese pound
        /// </summary>
        SDG = 938,

        /// <summary>
        /// Swedish krona
        /// </summary>
        SEK = 752,

        /// <summary>
        /// Singapore dollar
        /// </summary>
        SGD = 702,

        /// <summary>
        /// Saint Helena pound
        /// </summary>
        SHP = 654,

        /// <summary>
        /// Sierra Leonean leone
        /// </summary>
        SLE = 925,

        /// <summary>
        /// Somalian shilling
        /// </summary>
        SOS = 706,

        /// <summary>
        /// Surinamese dollar
        /// </summary>
        SRD = 968,

        /// <summary>
        /// South Sudanese pound
        /// </summary>
        SSP = 728,

        /// <summary>
        /// São Tomé and Príncipe dobra
        /// </summary>
        STN = 930,

        /// <summary>
        /// Salvadoran colón
        /// </summary>
        SVC = 222,

        /// <summary>
        /// Syrian pound
        /// </summary>
        SYP = 760,

        /// <summary>
        /// Swazi lilangeni
        /// </summary>
        SZL = 748,

        /// <summary>
        /// Thai baht
        /// </summary>
        THB = 764,

        /// <summary>
        /// Tajikistani somoni
        /// </summary>
        TJS = 972,

        /// <summary>
        /// Turkmenistan manat
        /// </summary>
        TMT = 934,

        /// <summary>
        /// Tunisian dinar
        /// </summary>
        TND = 788,

        /// <summary>
        /// Tongan paʻanga
        /// </summary>
        TOP = 776,

        /// <summary>
        /// Turkish lira
        /// </summary>
        TRY = 949,

        /// <summary>
        /// Trinidad and Tobago dollar
        /// </summary>
        TTD = 780,

        /// <summary>
        /// New Taiwan dollar
        /// </summary>
        TWD = 901,

        /// <summary>
        /// Tanzanian shilling
        /// </summary>
        TZS = 834,

        /// <summary>
        /// Ukrainian hryvnia
        /// </summary>
        UAH = 980,

        /// <summary>
        /// Ugandan shilling
        /// </summary>
        UGX = 800,

        /// <summary>
        /// United States dollar
        /// </summary>
        USD = 840,

        /// <summary>
        /// United States dollar
        /// </summary>
        USN = 997,

        /// <summary>
        /// Uruguay Peso en Unidades Indexadas
        /// </summary>
        UYI = 940,

        /// <summary>
        /// Uruguayan peso
        /// </summary>
        UYU = 858,

        /// <summary>
        /// Unidad previsional
        /// </summary>
        UYW = 927,

        /// <summary>
        /// Uzbekistani sum
        /// </summary>
        UZS = 860,

        /// <summary>
        /// Venezuelan digital bolívar
        /// </summary>
        VED = 926,

        /// <summary>
        /// Venezuelan sovereign bolívar
        /// </summary>
        VES = 928,

        /// <summary>
        /// Vietnamese đồng
        /// </summary>
        VND = 704,

        /// <summary>
        /// Vanuatu vatu
        /// </summary>
        VUV = 548,

        /// <summary>
        /// Samoan tala
        /// </summary>
        WST = 882,

        /// <summary>
        /// CFA franc BEAC
        /// </summary>
        XAF = 950,

        /// <summary>
        /// Silver
        /// </summary>
        XAG = 961,

        /// <summary>
        /// Gold
        /// </summary>
        XAU = 959,

        /// <summary>
        /// European Composite Unit
        /// </summary>
        XBA = 955,

        /// <summary>
        /// European Monetary Unit
        /// </summary>
        XBB = 956,

        /// <summary>
        /// European Unit of Account
        /// </summary>
        XBC = 957,

        /// <summary>
        /// European Unit of Account
        /// </summary>
        XBD = 958,

        /// <summary>
        /// East Caribbean dollar
        /// </summary>
        XCD = 951,

        /// <summary>
        /// Special drawing rights
        /// </summary>
        XDR = 960,

        /// <summary>
        /// CFA franc BCEAO
        /// </summary>
        XOF = 952,

        /// <summary>
        /// Palladium
        /// </summary>
        XPD = 964,

        /// <summary>
        /// CFP franc
        /// </summary>
        XPF = 953,

        /// <summary>
        /// Platinum
        /// </summary>
        XPT = 962,

        /// <summary>
        /// SUCRE
        /// </summary>
        XSU = 994,

        /// <summary>
        /// Code reserved for testing
        /// </summary>
        XTS = 963,

        /// <summary>
        /// ADB Unit of Account
        /// </summary>
        XUA = 965,

        /// <summary>
        /// No currency
        /// </summary>
        XXX = 999,

        /// <summary>
        /// Yemeni rial
        /// </summary>
        YER = 886,

        /// <summary>
        /// South African rand
        /// </summary>
        ZAR = 710,

        /// <summary>
        /// Zambian kwacha
        /// </summary>
        ZMW = 967,

        /// <summary>
        /// Zimbabwe Gold
        /// </summary>
        ZWG = 924
    }
}
