namespace EPC.Monetary
{
    public class Currency
    {
        /// <summary>
        /// Currency code
        /// </summary>
        public required CurrencyCode Code { get; init; }

        /// <summary>
        /// Currency precision
        /// </summary>
        public byte? Precision { get; init; }

        /// <summary>
        /// Currency english name
        /// </summary>
        public required string Name { get; init; }

        #region All

        /* https://en.wikipedia.org/wiki/ISO_4217#Active_codes_(list_one)
         * Regex: (\w+) 	\d+ 	([\d\.])(?:\S+)? 	([\p{L} ]+\p{L}+).*$
         * Substitution: /// <summary>\n/// $3\n/// </summary>\npublic static Currency $1 { get; } = new Currency { Code = CurrencyCode.$1, Precision = $2, Name = "$3" };\n
         */

        /// <summary>
        /// United Arab Emirates dirham
        /// </summary>
        public static Currency AED { get; } = new Currency { Code = CurrencyCode.AED, Precision = 2, Name = "United Arab Emirates dirham" };

        /// <summary>
        /// Afghan afghani
        /// </summary>
        public static Currency AFN { get; } = new Currency { Code = CurrencyCode.AFN, Precision = 2, Name = "Afghan afghani" };

        /// <summary>
        /// Albanian lek
        /// </summary>
        public static Currency ALL { get; } = new Currency { Code = CurrencyCode.ALL, Precision = 2, Name = "Albanian lek" };

        /// <summary>
        /// Armenian dram
        /// </summary>
        public static Currency AMD { get; } = new Currency { Code = CurrencyCode.AMD, Precision = 2, Name = "Armenian dram" };

        /// <summary>
        /// Netherlands Antillean guilder
        /// </summary>
        public static Currency ANG { get; } = new Currency { Code = CurrencyCode.ANG, Precision = 2, Name = "Netherlands Antillean guilder" };

        /// <summary>
        /// Angolan kwanza
        /// </summary>
        public static Currency AOA { get; } = new Currency { Code = CurrencyCode.AOA, Precision = 2, Name = "Angolan kwanza" };

        /// <summary>
        /// Argentine peso
        /// </summary>
        public static Currency ARS { get; } = new Currency { Code = CurrencyCode.ARS, Precision = 2, Name = "Argentine peso" };

        /// <summary>
        /// Australian dollar
        /// </summary>
        public static Currency AUD { get; } = new Currency { Code = CurrencyCode.AUD, Precision = 2, Name = "Australian dollar" };

        /// <summary>
        /// Aruban florin
        /// </summary>
        public static Currency AWG { get; } = new Currency { Code = CurrencyCode.AWG, Precision = 2, Name = "Aruban florin" };

        /// <summary>
        /// Azerbaijani manat
        /// </summary>
        public static Currency AZN { get; } = new Currency { Code = CurrencyCode.AZN, Precision = 2, Name = "Azerbaijani manat" };

        /// <summary>
        /// Bosnia and Herzegovina convertible mark
        /// </summary>
        public static Currency BAM { get; } = new Currency { Code = CurrencyCode.BAM, Precision = 2, Name = "Bosnia and Herzegovina convertible mark" };

        /// <summary>
        /// Barbados dollar
        /// </summary>
        public static Currency BBD { get; } = new Currency { Code = CurrencyCode.BBD, Precision = 2, Name = "Barbados dollar" };

        /// <summary>
        /// Bangladeshi taka
        /// </summary>
        public static Currency BDT { get; } = new Currency { Code = CurrencyCode.BDT, Precision = 2, Name = "Bangladeshi taka" };

        /// <summary>
        /// Bulgarian lev
        /// </summary>
        public static Currency BGN { get; } = new Currency { Code = CurrencyCode.BGN, Precision = 2, Name = "Bulgarian lev" };

        /// <summary>
        /// Bahraini dinar
        /// </summary>
        public static Currency BHD { get; } = new Currency { Code = CurrencyCode.BHD, Precision = 3, Name = "Bahraini dinar" };

        /// <summary>
        /// Burundian franc
        /// </summary>
        public static Currency BIF { get; } = new Currency { Code = CurrencyCode.BIF, Precision = 0, Name = "Burundian franc" };

        /// <summary>
        /// Bermudian dollar
        /// </summary>
        public static Currency BMD { get; } = new Currency { Code = CurrencyCode.BMD, Precision = 2, Name = "Bermudian dollar" };

        /// <summary>
        /// Brunei dollar
        /// </summary>
        public static Currency BND { get; } = new Currency { Code = CurrencyCode.BND, Precision = 2, Name = "Brunei dollar" };

        /// <summary>
        /// Boliviano
        /// </summary>
        public static Currency BOB { get; } = new Currency { Code = CurrencyCode.BOB, Precision = 2, Name = "Boliviano" };

        /// <summary>
        /// Bolivian Mvdol
        /// </summary>
        public static Currency BOV { get; } = new Currency { Code = CurrencyCode.BOV, Precision = 2, Name = "Bolivian Mvdol" };

        /// <summary>
        /// Brazilian real
        /// </summary>
        public static Currency BRL { get; } = new Currency { Code = CurrencyCode.BRL, Precision = 2, Name = "Brazilian real" };

        /// <summary>
        /// Bahamian dollar
        /// </summary>
        public static Currency BSD { get; } = new Currency { Code = CurrencyCode.BSD, Precision = 2, Name = "Bahamian dollar" };

        /// <summary>
        /// Bhutanese ngultrum
        /// </summary>
        public static Currency BTN { get; } = new Currency { Code = CurrencyCode.BTN, Precision = 2, Name = "Bhutanese ngultrum" };

        /// <summary>
        /// Botswana pula
        /// </summary>
        public static Currency BWP { get; } = new Currency { Code = CurrencyCode.BWP, Precision = 2, Name = "Botswana pula" };

        /// <summary>
        /// Belarusian ruble
        /// </summary>
        public static Currency BYN { get; } = new Currency { Code = CurrencyCode.BYN, Precision = 2, Name = "Belarusian ruble" };

        /// <summary>
        /// Belize dollar
        /// </summary>
        public static Currency BZD { get; } = new Currency { Code = CurrencyCode.BZD, Precision = 2, Name = "Belize dollar" };

        /// <summary>
        /// Canadian dollar
        /// </summary>
        public static Currency CAD { get; } = new Currency { Code = CurrencyCode.CAD, Precision = 2, Name = "Canadian dollar" };

        /// <summary>
        /// Congolese franc
        /// </summary>
        public static Currency CDF { get; } = new Currency { Code = CurrencyCode.CDF, Precision = 2, Name = "Congolese franc" };

        /// <summary>
        /// WIR euro
        /// </summary>
        public static Currency CHE { get; } = new Currency { Code = CurrencyCode.CHE, Precision = 2, Name = "WIR euro" };

        /// <summary>
        /// Swiss franc
        /// </summary>
        public static Currency CHF { get; } = new Currency { Code = CurrencyCode.CHF, Precision = 2, Name = "Swiss franc" };

        /// <summary>
        /// WIR franc
        /// </summary>
        public static Currency CHW { get; } = new Currency { Code = CurrencyCode.CHW, Precision = 2, Name = "WIR franc" };

        /// <summary>
        /// Unidad de Fomento
        /// </summary>
        public static Currency CLF { get; } = new Currency { Code = CurrencyCode.CLF, Precision = 4, Name = "Unidad de Fomento" };

        /// <summary>
        /// Chilean peso
        /// </summary>
        public static Currency CLP { get; } = new Currency { Code = CurrencyCode.CLP, Precision = 0, Name = "Chilean peso" };

        /// <summary>
        /// Renminbi
        /// </summary>
        public static Currency CNY { get; } = new Currency { Code = CurrencyCode.CNY, Precision = 2, Name = "Renminbi" };

        /// <summary>
        /// Colombian peso
        /// </summary>
        public static Currency COP { get; } = new Currency { Code = CurrencyCode.COP, Precision = 2, Name = "Colombian peso" };

        /// <summary>
        /// Unidad de Valor Real
        /// </summary>
        public static Currency COU { get; } = new Currency { Code = CurrencyCode.COU, Precision = 2, Name = "Unidad de Valor Real" };

        /// <summary>
        /// Costa Rican colon
        /// </summary>
        public static Currency CRC { get; } = new Currency { Code = CurrencyCode.CRC, Precision = 2, Name = "Costa Rican colon" };

        /// <summary>
        /// Cuban peso
        /// </summary>
        public static Currency CUP { get; } = new Currency { Code = CurrencyCode.CUP, Precision = 2, Name = "Cuban peso" };

        /// <summary>
        /// Cape Verdean escudo
        /// </summary>
        public static Currency CVE { get; } = new Currency { Code = CurrencyCode.CVE, Precision = 2, Name = "Cape Verdean escudo" };

        /// <summary>
        /// Czech koruna
        /// </summary>
        public static Currency CZK { get; } = new Currency { Code = CurrencyCode.CZK, Precision = 2, Name = "Czech koruna" };

        /// <summary>
        /// Djiboutian franc
        /// </summary>
        public static Currency DJF { get; } = new Currency { Code = CurrencyCode.DJF, Precision = 0, Name = "Djiboutian franc" };

        /// <summary>
        /// Danish krone
        /// </summary>
        public static Currency DKK { get; } = new Currency { Code = CurrencyCode.DKK, Precision = 2, Name = "Danish krone" };

        /// <summary>
        /// Dominican peso
        /// </summary>
        public static Currency DOP { get; } = new Currency { Code = CurrencyCode.DOP, Precision = 2, Name = "Dominican peso" };

        /// <summary>
        /// Algerian dinar
        /// </summary>
        public static Currency DZD { get; } = new Currency { Code = CurrencyCode.DZD, Precision = 2, Name = "Algerian dinar" };

        /// <summary>
        /// Egyptian pound
        /// </summary>
        public static Currency EGP { get; } = new Currency { Code = CurrencyCode.EGP, Precision = 2, Name = "Egyptian pound" };

        /// <summary>
        /// Eritrean nakfa
        /// </summary>
        public static Currency ERN { get; } = new Currency { Code = CurrencyCode.ERN, Precision = 2, Name = "Eritrean nakfa" };

        /// <summary>
        /// Ethiopian birr
        /// </summary>
        public static Currency ETB { get; } = new Currency { Code = CurrencyCode.ETB, Precision = 2, Name = "Ethiopian birr" };

        /// <summary>
        /// Euro
        /// </summary>
        public static Currency EUR { get; } = new Currency { Code = CurrencyCode.EUR, Precision = 2, Name = "Euro" };

        /// <summary>
        /// Fiji dollar
        /// </summary>
        public static Currency FJD { get; } = new Currency { Code = CurrencyCode.FJD, Precision = 2, Name = "Fiji dollar" };

        /// <summary>
        /// Falkland Islands pound
        /// </summary>
        public static Currency FKP { get; } = new Currency { Code = CurrencyCode.FKP, Precision = 2, Name = "Falkland Islands pound" };

        /// <summary>
        /// Pound sterling
        /// </summary>
        public static Currency GBP { get; } = new Currency { Code = CurrencyCode.GBP, Precision = 2, Name = "Pound sterling" };

        /// <summary>
        /// Georgian lari
        /// </summary>
        public static Currency GEL { get; } = new Currency { Code = CurrencyCode.GEL, Precision = 2, Name = "Georgian lari" };

        /// <summary>
        /// Ghanaian cedi
        /// </summary>
        public static Currency GHS { get; } = new Currency { Code = CurrencyCode.GHS, Precision = 2, Name = "Ghanaian cedi" };

        /// <summary>
        /// Gibraltar pound
        /// </summary>
        public static Currency GIP { get; } = new Currency { Code = CurrencyCode.GIP, Precision = 2, Name = "Gibraltar pound" };

        /// <summary>
        /// Gambian dalasi
        /// </summary>
        public static Currency GMD { get; } = new Currency { Code = CurrencyCode.GMD, Precision = 2, Name = "Gambian dalasi" };

        /// <summary>
        /// Guinean franc
        /// </summary>
        public static Currency GNF { get; } = new Currency { Code = CurrencyCode.GNF, Precision = 0, Name = "Guinean franc" };

        /// <summary>
        /// Guatemalan quetzal
        /// </summary>
        public static Currency GTQ { get; } = new Currency { Code = CurrencyCode.GTQ, Precision = 2, Name = "Guatemalan quetzal" };

        /// <summary>
        /// Guyanese dollar
        /// </summary>
        public static Currency GYD { get; } = new Currency { Code = CurrencyCode.GYD, Precision = 2, Name = "Guyanese dollar" };

        /// <summary>
        /// Hong Kong dollar
        /// </summary>
        public static Currency HKD { get; } = new Currency { Code = CurrencyCode.HKD, Precision = 2, Name = "Hong Kong dollar" };

        /// <summary>
        /// Honduran lempira
        /// </summary>
        public static Currency HNL { get; } = new Currency { Code = CurrencyCode.HNL, Precision = 2, Name = "Honduran lempira" };

        /// <summary>
        /// Haitian gourde
        /// </summary>
        public static Currency HTG { get; } = new Currency { Code = CurrencyCode.HTG, Precision = 2, Name = "Haitian gourde" };

        /// <summary>
        /// Hungarian forint
        /// </summary>
        public static Currency HUF { get; } = new Currency { Code = CurrencyCode.HUF, Precision = 2, Name = "Hungarian forint" };

        /// <summary>
        /// Indonesian rupiah
        /// </summary>
        public static Currency IDR { get; } = new Currency { Code = CurrencyCode.IDR, Precision = 2, Name = "Indonesian rupiah" };

        /// <summary>
        /// Israeli new shekel
        /// </summary>
        public static Currency ILS { get; } = new Currency { Code = CurrencyCode.ILS, Precision = 2, Name = "Israeli new shekel" };

        /// <summary>
        /// Indian rupee
        /// </summary>
        public static Currency INR { get; } = new Currency { Code = CurrencyCode.INR, Precision = 2, Name = "Indian rupee" };

        /// <summary>
        /// Iraqi dinar
        /// </summary>
        public static Currency IQD { get; } = new Currency { Code = CurrencyCode.IQD, Precision = 3, Name = "Iraqi dinar" };

        /// <summary>
        /// Iranian rial
        /// </summary>
        public static Currency IRR { get; } = new Currency { Code = CurrencyCode.IRR, Precision = 2, Name = "Iranian rial" };

        /// <summary>
        /// Icelandic króna
        /// </summary>
        public static Currency ISK { get; } = new Currency { Code = CurrencyCode.ISK, Precision = 0, Name = "Icelandic króna" };

        /// <summary>
        /// Jamaican dollar
        /// </summary>
        public static Currency JMD { get; } = new Currency { Code = CurrencyCode.JMD, Precision = 2, Name = "Jamaican dollar" };

        /// <summary>
        /// Jordanian dinar
        /// </summary>
        public static Currency JOD { get; } = new Currency { Code = CurrencyCode.JOD, Precision = 3, Name = "Jordanian dinar" };

        /// <summary>
        /// Japanese yen
        /// </summary>
        public static Currency JPY { get; } = new Currency { Code = CurrencyCode.JPY, Precision = 0, Name = "Japanese yen" };

        /// <summary>
        /// Kenyan shilling
        /// </summary>
        public static Currency KES { get; } = new Currency { Code = CurrencyCode.KES, Precision = 2, Name = "Kenyan shilling" };

        /// <summary>
        /// Kyrgyzstani som
        /// </summary>
        public static Currency KGS { get; } = new Currency { Code = CurrencyCode.KGS, Precision = 2, Name = "Kyrgyzstani som" };

        /// <summary>
        /// Cambodian riel
        /// </summary>
        public static Currency KHR { get; } = new Currency { Code = CurrencyCode.KHR, Precision = 2, Name = "Cambodian riel" };

        /// <summary>
        /// Comoro franc
        /// </summary>
        public static Currency KMF { get; } = new Currency { Code = CurrencyCode.KMF, Precision = 0, Name = "Comoro franc" };

        /// <summary>
        /// North Korean won
        /// </summary>
        public static Currency KPW { get; } = new Currency { Code = CurrencyCode.KPW, Precision = 2, Name = "North Korean won" };

        /// <summary>
        /// South Korean won
        /// </summary>
        public static Currency KRW { get; } = new Currency { Code = CurrencyCode.KRW, Precision = 0, Name = "South Korean won" };

        /// <summary>
        /// Kuwaiti dinar
        /// </summary>
        public static Currency KWD { get; } = new Currency { Code = CurrencyCode.KWD, Precision = 3, Name = "Kuwaiti dinar" };

        /// <summary>
        /// Cayman Islands dollar
        /// </summary>
        public static Currency KYD { get; } = new Currency { Code = CurrencyCode.KYD, Precision = 2, Name = "Cayman Islands dollar" };

        /// <summary>
        /// Kazakhstani tenge
        /// </summary>
        public static Currency KZT { get; } = new Currency { Code = CurrencyCode.KZT, Precision = 2, Name = "Kazakhstani tenge" };

        /// <summary>
        /// Lao kip
        /// </summary>
        public static Currency LAK { get; } = new Currency { Code = CurrencyCode.LAK, Precision = 2, Name = "Lao kip" };

        /// <summary>
        /// Lebanese pound
        /// </summary>
        public static Currency LBP { get; } = new Currency { Code = CurrencyCode.LBP, Precision = 2, Name = "Lebanese pound" };

        /// <summary>
        /// Sri Lankan rupee
        /// </summary>
        public static Currency LKR { get; } = new Currency { Code = CurrencyCode.LKR, Precision = 2, Name = "Sri Lankan rupee" };

        /// <summary>
        /// Liberian dollar
        /// </summary>
        public static Currency LRD { get; } = new Currency { Code = CurrencyCode.LRD, Precision = 2, Name = "Liberian dollar" };

        /// <summary>
        /// Lesotho loti
        /// </summary>
        public static Currency LSL { get; } = new Currency { Code = CurrencyCode.LSL, Precision = 2, Name = "Lesotho loti" };

        /// <summary>
        /// Libyan dinar
        /// </summary>
        public static Currency LYD { get; } = new Currency { Code = CurrencyCode.LYD, Precision = 3, Name = "Libyan dinar" };

        /// <summary>
        /// Moroccan dirham
        /// </summary>
        public static Currency MAD { get; } = new Currency { Code = CurrencyCode.MAD, Precision = 2, Name = "Moroccan dirham" };

        /// <summary>
        /// Moldovan leu
        /// </summary>
        public static Currency MDL { get; } = new Currency { Code = CurrencyCode.MDL, Precision = 2, Name = "Moldovan leu" };

        /// <summary>
        /// Malagasy ariary
        /// </summary>
        public static Currency MGA { get; } = new Currency { Code = CurrencyCode.MGA, Precision = 2, Name = "Malagasy ariary" };

        /// <summary>
        /// Macedonian denar
        /// </summary>
        public static Currency MKD { get; } = new Currency { Code = CurrencyCode.MKD, Precision = 2, Name = "Macedonian denar" };

        /// <summary>
        /// Myanmar kyat
        /// </summary>
        public static Currency MMK { get; } = new Currency { Code = CurrencyCode.MMK, Precision = 2, Name = "Myanmar kyat" };

        /// <summary>
        /// Mongolian tögrög
        /// </summary>
        public static Currency MNT { get; } = new Currency { Code = CurrencyCode.MNT, Precision = 2, Name = "Mongolian tögrög" };

        /// <summary>
        /// Macanese pataca
        /// </summary>
        public static Currency MOP { get; } = new Currency { Code = CurrencyCode.MOP, Precision = 2, Name = "Macanese pataca" };

        /// <summary>
        /// Mauritanian ouguiya
        /// </summary>
        public static Currency MRU { get; } = new Currency { Code = CurrencyCode.MRU, Precision = 2, Name = "Mauritanian ouguiya" };

        /// <summary>
        /// Mauritian rupee
        /// </summary>
        public static Currency MUR { get; } = new Currency { Code = CurrencyCode.MUR, Precision = 2, Name = "Mauritian rupee" };

        /// <summary>
        /// Maldivian rufiyaa
        /// </summary>
        public static Currency MVR { get; } = new Currency { Code = CurrencyCode.MVR, Precision = 2, Name = "Maldivian rufiyaa" };

        /// <summary>
        /// Malawian kwacha
        /// </summary>
        public static Currency MWK { get; } = new Currency { Code = CurrencyCode.MWK, Precision = 2, Name = "Malawian kwacha" };

        /// <summary>
        /// Mexican peso
        /// </summary>
        public static Currency MXN { get; } = new Currency { Code = CurrencyCode.MXN, Precision = 2, Name = "Mexican peso" };

        /// <summary>
        /// Mexican Unidad de Inversion
        /// </summary>
        public static Currency MXV { get; } = new Currency { Code = CurrencyCode.MXV, Precision = 2, Name = "Mexican Unidad de Inversion" };

        /// <summary>
        /// Malaysian ringgit
        /// </summary>
        public static Currency MYR { get; } = new Currency { Code = CurrencyCode.MYR, Precision = 2, Name = "Malaysian ringgit" };

        /// <summary>
        /// Mozambican metical
        /// </summary>
        public static Currency MZN { get; } = new Currency { Code = CurrencyCode.MZN, Precision = 2, Name = "Mozambican metical" };

        /// <summary>
        /// Namibian dollar
        /// </summary>
        public static Currency NAD { get; } = new Currency { Code = CurrencyCode.NAD, Precision = 2, Name = "Namibian dollar" };

        /// <summary>
        /// Nigerian naira
        /// </summary>
        public static Currency NGN { get; } = new Currency { Code = CurrencyCode.NGN, Precision = 2, Name = "Nigerian naira" };

        /// <summary>
        /// Nicaraguan córdoba
        /// </summary>
        public static Currency NIO { get; } = new Currency { Code = CurrencyCode.NIO, Precision = 2, Name = "Nicaraguan córdoba" };

        /// <summary>
        /// Norwegian krone
        /// </summary>
        public static Currency NOK { get; } = new Currency { Code = CurrencyCode.NOK, Precision = 2, Name = "Norwegian krone" };

        /// <summary>
        /// Nepalese rupee
        /// </summary>
        public static Currency NPR { get; } = new Currency { Code = CurrencyCode.NPR, Precision = 2, Name = "Nepalese rupee" };

        /// <summary>
        /// New Zealand dollar
        /// </summary>
        public static Currency NZD { get; } = new Currency { Code = CurrencyCode.NZD, Precision = 2, Name = "New Zealand dollar" };

        /// <summary>
        /// Omani rial
        /// </summary>
        public static Currency OMR { get; } = new Currency { Code = CurrencyCode.OMR, Precision = 3, Name = "Omani rial" };

        /// <summary>
        /// Panamanian balboa
        /// </summary>
        public static Currency PAB { get; } = new Currency { Code = CurrencyCode.PAB, Precision = 2, Name = "Panamanian balboa" };

        /// <summary>
        /// Peruvian sol
        /// </summary>
        public static Currency PEN { get; } = new Currency { Code = CurrencyCode.PEN, Precision = 2, Name = "Peruvian sol" };

        /// <summary>
        /// Papua New Guinean kina
        /// </summary>
        public static Currency PGK { get; } = new Currency { Code = CurrencyCode.PGK, Precision = 2, Name = "Papua New Guinean kina" };

        /// <summary>
        /// Philippine peso
        /// </summary>
        public static Currency PHP { get; } = new Currency { Code = CurrencyCode.PHP, Precision = 2, Name = "Philippine peso" };

        /// <summary>
        /// Pakistani rupee
        /// </summary>
        public static Currency PKR { get; } = new Currency { Code = CurrencyCode.PKR, Precision = 2, Name = "Pakistani rupee" };

        /// <summary>
        /// Polish złoty
        /// </summary>
        public static Currency PLN { get; } = new Currency { Code = CurrencyCode.PLN, Precision = 2, Name = "Polish złoty" };

        /// <summary>
        /// Paraguayan guaraní
        /// </summary>
        public static Currency PYG { get; } = new Currency { Code = CurrencyCode.PYG, Precision = 0, Name = "Paraguayan guaraní" };

        /// <summary>
        /// Qatari riyal
        /// </summary>
        public static Currency QAR { get; } = new Currency { Code = CurrencyCode.QAR, Precision = 2, Name = "Qatari riyal" };

        /// <summary>
        /// Romanian leu
        /// </summary>
        public static Currency RON { get; } = new Currency { Code = CurrencyCode.RON, Precision = 2, Name = "Romanian leu" };

        /// <summary>
        /// Serbian dinar
        /// </summary>
        public static Currency RSD { get; } = new Currency { Code = CurrencyCode.RSD, Precision = 2, Name = "Serbian dinar" };

        /// <summary>
        /// Russian ruble
        /// </summary>
        public static Currency RUB { get; } = new Currency { Code = CurrencyCode.RUB, Precision = 2, Name = "Russian ruble" };

        /// <summary>
        /// Rwandan franc
        /// </summary>
        public static Currency RWF { get; } = new Currency { Code = CurrencyCode.RWF, Precision = 0, Name = "Rwandan franc" };

        /// <summary>
        /// Saudi riyal
        /// </summary>
        public static Currency SAR { get; } = new Currency { Code = CurrencyCode.SAR, Precision = 2, Name = "Saudi riyal" };

        /// <summary>
        /// Solomon Islands dollar
        /// </summary>
        public static Currency SBD { get; } = new Currency { Code = CurrencyCode.SBD, Precision = 2, Name = "Solomon Islands dollar" };

        /// <summary>
        /// Seychelles rupee
        /// </summary>
        public static Currency SCR { get; } = new Currency { Code = CurrencyCode.SCR, Precision = 2, Name = "Seychelles rupee" };

        /// <summary>
        /// Sudanese pound
        /// </summary>
        public static Currency SDG { get; } = new Currency { Code = CurrencyCode.SDG, Precision = 2, Name = "Sudanese pound" };

        /// <summary>
        /// Swedish krona
        /// </summary>
        public static Currency SEK { get; } = new Currency { Code = CurrencyCode.SEK, Precision = 2, Name = "Swedish krona" };

        /// <summary>
        /// Singapore dollar
        /// </summary>
        public static Currency SGD { get; } = new Currency { Code = CurrencyCode.SGD, Precision = 2, Name = "Singapore dollar" };

        /// <summary>
        /// Saint Helena pound
        /// </summary>
        public static Currency SHP { get; } = new Currency { Code = CurrencyCode.SHP, Precision = 2, Name = "Saint Helena pound" };

        /// <summary>
        /// Sierra Leonean leone
        /// </summary>
        public static Currency SLE { get; } = new Currency { Code = CurrencyCode.SLE, Precision = 2, Name = "Sierra Leonean leone" };

        /// <summary>
        /// Somalian shilling
        /// </summary>
        public static Currency SOS { get; } = new Currency { Code = CurrencyCode.SOS, Precision = 2, Name = "Somalian shilling" };

        /// <summary>
        /// Surinamese dollar
        /// </summary>
        public static Currency SRD { get; } = new Currency { Code = CurrencyCode.SRD, Precision = 2, Name = "Surinamese dollar" };

        /// <summary>
        /// South Sudanese pound
        /// </summary>
        public static Currency SSP { get; } = new Currency { Code = CurrencyCode.SSP, Precision = 2, Name = "South Sudanese pound" };

        /// <summary>
        /// São Tomé and Príncipe dobra
        /// </summary>
        public static Currency STN { get; } = new Currency { Code = CurrencyCode.STN, Precision = 2, Name = "São Tomé and Príncipe dobra" };

        /// <summary>
        /// Salvadoran colón
        /// </summary>
        public static Currency SVC { get; } = new Currency { Code = CurrencyCode.SVC, Precision = 2, Name = "Salvadoran colón" };

        /// <summary>
        /// Syrian pound
        /// </summary>
        public static Currency SYP { get; } = new Currency { Code = CurrencyCode.SYP, Precision = 2, Name = "Syrian pound" };

        /// <summary>
        /// Swazi lilangeni
        /// </summary>
        public static Currency SZL { get; } = new Currency { Code = CurrencyCode.SZL, Precision = 2, Name = "Swazi lilangeni" };

        /// <summary>
        /// Thai baht
        /// </summary>
        public static Currency THB { get; } = new Currency { Code = CurrencyCode.THB, Precision = 2, Name = "Thai baht" };

        /// <summary>
        /// Tajikistani somoni
        /// </summary>
        public static Currency TJS { get; } = new Currency { Code = CurrencyCode.TJS, Precision = 2, Name = "Tajikistani somoni" };

        /// <summary>
        /// Turkmenistan manat
        /// </summary>
        public static Currency TMT { get; } = new Currency { Code = CurrencyCode.TMT, Precision = 2, Name = "Turkmenistan manat" };

        /// <summary>
        /// Tunisian dinar
        /// </summary>
        public static Currency TND { get; } = new Currency { Code = CurrencyCode.TND, Precision = 3, Name = "Tunisian dinar" };

        /// <summary>
        /// Tongan paʻanga
        /// </summary>
        public static Currency TOP { get; } = new Currency { Code = CurrencyCode.TOP, Precision = 2, Name = "Tongan paʻanga" };

        /// <summary>
        /// Turkish lira
        /// </summary>
        public static Currency TRY { get; } = new Currency { Code = CurrencyCode.TRY, Precision = 2, Name = "Turkish lira" };

        /// <summary>
        /// Trinidad and Tobago dollar
        /// </summary>
        public static Currency TTD { get; } = new Currency { Code = CurrencyCode.TTD, Precision = 2, Name = "Trinidad and Tobago dollar" };

        /// <summary>
        /// New Taiwan dollar
        /// </summary>
        public static Currency TWD { get; } = new Currency { Code = CurrencyCode.TWD, Precision = 2, Name = "New Taiwan dollar" };

        /// <summary>
        /// Tanzanian shilling
        /// </summary>
        public static Currency TZS { get; } = new Currency { Code = CurrencyCode.TZS, Precision = 2, Name = "Tanzanian shilling" };

        /// <summary>
        /// Ukrainian hryvnia
        /// </summary>
        public static Currency UAH { get; } = new Currency { Code = CurrencyCode.UAH, Precision = 2, Name = "Ukrainian hryvnia" };

        /// <summary>
        /// Ugandan shilling
        /// </summary>
        public static Currency UGX { get; } = new Currency { Code = CurrencyCode.UGX, Precision = 0, Name = "Ugandan shilling" };

        /// <summary>
        /// United States dollar
        /// </summary>
        public static Currency USD { get; } = new Currency { Code = CurrencyCode.USD, Precision = 2, Name = "United States dollar" };

        /// <summary>
        /// United States dollar
        /// </summary>
        public static Currency USN { get; } = new Currency { Code = CurrencyCode.USN, Precision = 2, Name = "United States dollar" };

        /// <summary>
        /// Uruguay Peso en Unidades Indexadas
        /// </summary>
        public static Currency UYI { get; } = new Currency { Code = CurrencyCode.UYI, Precision = 0, Name = "Uruguay Peso en Unidades Indexadas" };

        /// <summary>
        /// Uruguayan peso
        /// </summary>
        public static Currency UYU { get; } = new Currency { Code = CurrencyCode.UYU, Precision = 2, Name = "Uruguayan peso" };

        /// <summary>
        /// Unidad previsional
        /// </summary>
        public static Currency UYW { get; } = new Currency { Code = CurrencyCode.UYW, Precision = 4, Name = "Unidad previsional" };

        /// <summary>
        /// Uzbekistani sum
        /// </summary>
        public static Currency UZS { get; } = new Currency { Code = CurrencyCode.UZS, Precision = 2, Name = "Uzbekistani sum" };

        /// <summary>
        /// Venezuelan digital bolívar
        /// </summary>
        public static Currency VED { get; } = new Currency { Code = CurrencyCode.VED, Precision = 2, Name = "Venezuelan digital bolívar" };

        /// <summary>
        /// Venezuelan sovereign bolívar
        /// </summary>
        public static Currency VES { get; } = new Currency { Code = CurrencyCode.VES, Precision = 2, Name = "Venezuelan sovereign bolívar" };

        /// <summary>
        /// Vietnamese đồng
        /// </summary>
        public static Currency VND { get; } = new Currency { Code = CurrencyCode.VND, Precision = 0, Name = "Vietnamese đồng" };

        /// <summary>
        /// Vanuatu vatu
        /// </summary>
        public static Currency VUV { get; } = new Currency { Code = CurrencyCode.VUV, Precision = 0, Name = "Vanuatu vatu" };

        /// <summary>
        /// Samoan tala
        /// </summary>
        public static Currency WST { get; } = new Currency { Code = CurrencyCode.WST, Precision = 2, Name = "Samoan tala" };

        /// <summary>
        /// CFA franc BEAC
        /// </summary>
        public static Currency XAF { get; } = new Currency { Code = CurrencyCode.XAF, Precision = 0, Name = "CFA franc BEAC" };

        /// <summary>
        /// Silver
        /// </summary>
        public static Currency XAG { get; } = new Currency { Code = CurrencyCode.XAG, Name = "Silver" };

        /// <summary>
        /// Gold
        /// </summary>
        public static Currency XAU { get; } = new Currency { Code = CurrencyCode.XAU, Name = "Gold" };

        /// <summary>
        /// European Composite Unit
        /// </summary>
        public static Currency XBA { get; } = new Currency { Code = CurrencyCode.XBA, Name = "European Composite Unit" };

        /// <summary>
        /// European Monetary Unit
        /// </summary>
        public static Currency XBB { get; } = new Currency { Code = CurrencyCode.XBB, Name = "European Monetary Unit" };

        /// <summary>
        /// European Unit of Account
        /// </summary>
        public static Currency XBC { get; } = new Currency { Code = CurrencyCode.XBC, Name = "European Unit of Account" };

        /// <summary>
        /// European Unit of Account
        /// </summary>
        public static Currency XBD { get; } = new Currency { Code = CurrencyCode.XBD, Name = "European Unit of Account" };

        /// <summary>
        /// East Caribbean dollar
        /// </summary>
        public static Currency XCD { get; } = new Currency { Code = CurrencyCode.XCD, Precision = 2, Name = "East Caribbean dollar" };

        /// <summary>
        /// Special drawing rights
        /// </summary>
        public static Currency XDR { get; } = new Currency { Code = CurrencyCode.XDR, Name = "Special drawing rights" };

        /// <summary>
        /// CFA franc BCEAO
        /// </summary>
        public static Currency XOF { get; } = new Currency { Code = CurrencyCode.XOF, Precision = 0, Name = "CFA franc BCEAO" };

        /// <summary>
        /// Palladium
        /// </summary>
        public static Currency XPD { get; } = new Currency { Code = CurrencyCode.XPD, Name = "Palladium" };

        /// <summary>
        /// CFP franc
        /// </summary>
        public static Currency XPF { get; } = new Currency { Code = CurrencyCode.XPF, Precision = 0, Name = "CFP franc" };

        /// <summary>
        /// Platinum
        /// </summary>
        public static Currency XPT { get; } = new Currency { Code = CurrencyCode.XPT, Name = "Platinum" };

        /// <summary>
        /// SUCRE
        /// </summary>
        public static Currency XSU { get; } = new Currency { Code = CurrencyCode.XSU, Name = "SUCRE" };

        /// <summary>
        /// Code reserved for testing
        /// </summary>
        public static Currency XTS { get; } = new Currency { Code = CurrencyCode.XTS, Name = "Code reserved for testing" };

        /// <summary>
        /// ADB Unit of Account
        /// </summary>
        public static Currency XUA { get; } = new Currency { Code = CurrencyCode.XUA, Name = "ADB Unit of Account" };

        /// <summary>
        /// No currency
        /// </summary>
        public static Currency XXX { get; } = new Currency { Code = CurrencyCode.XXX, Name = "No currency" };

        /// <summary>
        /// Yemeni rial
        /// </summary>
        public static Currency YER { get; } = new Currency { Code = CurrencyCode.YER, Precision = 2, Name = "Yemeni rial" };

        /// <summary>
        /// South African rand
        /// </summary>
        public static Currency ZAR { get; } = new Currency { Code = CurrencyCode.ZAR, Precision = 2, Name = "South African rand" };

        /// <summary>
        /// Zambian kwacha
        /// </summary>
        public static Currency ZMW { get; } = new Currency { Code = CurrencyCode.ZMW, Precision = 2, Name = "Zambian kwacha" };

        /// <summary>
        /// Zimbabwe Gold
        /// </summary>
        public static Currency ZWG { get; } = new Currency { Code = CurrencyCode.ZWG, Precision = 2, Name = "Zimbabwe Gold" };

        #endregion

        // IMPORTANT: This need to be AFTER all the currency properties!
        public static IReadOnlyCollection<Currency> All { get; } = typeof(Currency).GetProperties(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)
                                                                           .Where(property => property.PropertyType == typeof(Currency))
                                                                           .Select(property => (Currency)property.GetValue(null)!)
                                                                           .ToList();

        public static IReadOnlyDictionary<CurrencyCode, Currency> AllByCode { get; } = All.ToDictionary(x => x.Code);
    }
}