using System.Drawing;

//https://materialui.co/
internal static class Colors
{
    public static Material Material => new Material();
    public static FlatUI FlatUI => new FlatUI();
    public static Social Social => new Social();
    public static Metro Metro => new Metro();
    public static HTML HTML => new HTML();
}

internal class Material
{
    //Red
    public Color Red50 = ColorTranslator.FromHtml("#FFEBEE");
    public Color Red100 = ColorTranslator.FromHtml("#FFCDD2");
    public Color Red200 = ColorTranslator.FromHtml("#EF9A9A");
    public Color Red300 = ColorTranslator.FromHtml("#E57373");
    public Color Red400 = ColorTranslator.FromHtml("#EF5350");
    public Color Red500 = ColorTranslator.FromHtml("#F44336");
    public Color Red600 = ColorTranslator.FromHtml("#E53935");
    public Color Red700 = ColorTranslator.FromHtml("#D32F2F");
    public Color Red800 = ColorTranslator.FromHtml("#C62828");
    public Color Red900 = ColorTranslator.FromHtml("#B71C1C");
    public Color RedA100 = ColorTranslator.FromHtml("#FF8A80");
    public Color RedA200 = ColorTranslator.FromHtml("#FF5252");
    public Color RedA400 = ColorTranslator.FromHtml("#FF1744");
    public Color RedA700 = ColorTranslator.FromHtml("#D50000");

    //Pink
    public Color Pink50 = ColorTranslator.FromHtml("#FCE4EC");
    public Color Pink100 = ColorTranslator.FromHtml("#F8BBD0");
    public Color Pink200 = ColorTranslator.FromHtml("#F48FB1");
    public Color Pink300 = ColorTranslator.FromHtml("#F06292");
    public Color Pink400 = ColorTranslator.FromHtml("#EC407A");
    public Color Pink500 = ColorTranslator.FromHtml("#E91E63");
    public Color Pink600 = ColorTranslator.FromHtml("#D81B60");
    public Color Pink700 = ColorTranslator.FromHtml("#C2185B");
    public Color Pink800 = ColorTranslator.FromHtml("#AD1457");
    public Color Pink900 = ColorTranslator.FromHtml("#880E4F");
    public Color PinkA100 = ColorTranslator.FromHtml("#FF80AB");
    public Color PinkA200 = ColorTranslator.FromHtml("#FF4081");
    public Color PinkA400 = ColorTranslator.FromHtml("#F50057");
    public Color PinkA700 = ColorTranslator.FromHtml("#C51162");

    //Purple
    public Color Purple50 = ColorTranslator.FromHtml("#F3E5F5");
    public Color Purple100 = ColorTranslator.FromHtml("#E1BEE7");
    public Color Purple200 = ColorTranslator.FromHtml("#CE93D8");
    public Color Purple300 = ColorTranslator.FromHtml("#BA68C8");
    public Color Purple400 = ColorTranslator.FromHtml("#AB47BC");
    public Color Purple500 = ColorTranslator.FromHtml("#9C27B0");
    public Color Purple600 = ColorTranslator.FromHtml("#8E24AA");
    public Color Purple700 = ColorTranslator.FromHtml("#7B1FA2");
    public Color Purple800 = ColorTranslator.FromHtml("#6A1B9A");
    public Color Purple900 = ColorTranslator.FromHtml("#4A148C");
    public Color PurpleA100 = ColorTranslator.FromHtml("#EA80FC");
    public Color PurpleA200 = ColorTranslator.FromHtml("#E040FB");
    public Color PurpleA400 = ColorTranslator.FromHtml("#D500F9");
    public Color PurpleA700 = ColorTranslator.FromHtml("#AA00FF");

    //Deep Purple
    public Color DeepPurple50 = ColorTranslator.FromHtml("#EDE7F6");
    public Color DeepPurple100 = ColorTranslator.FromHtml("#D1C4E9");
    public Color DeepPurple200 = ColorTranslator.FromHtml("#B39DDB");
    public Color DeepPurple300 = ColorTranslator.FromHtml("#9575CD");
    public Color DeepPurple400 = ColorTranslator.FromHtml("#7E57C2");
    public Color DeepPurple500 = ColorTranslator.FromHtml("#673AB7");
    public Color DeepPurple600 = ColorTranslator.FromHtml("#5E35B1");
    public Color DeepPurple700 = ColorTranslator.FromHtml("#512DA8");
    public Color DeepPurple800 = ColorTranslator.FromHtml("#4527A0");
    public Color DeepPurple900 = ColorTranslator.FromHtml("#311B92");
    public Color DeepPurpleA100 = ColorTranslator.FromHtml("#B388FF");
    public Color DeepPurpleA200 = ColorTranslator.FromHtml("#7C4DFF");
    public Color DeepPurpleA400 = ColorTranslator.FromHtml("#651FFF");
    public Color DeepPurpleA700 = ColorTranslator.FromHtml("#6200EA");

    //Indigo
    public Color Indigo50 = ColorTranslator.FromHtml("#E8EAF6");
    public Color Indigo100 = ColorTranslator.FromHtml("#C5CAE9");
    public Color Indigo200 = ColorTranslator.FromHtml("#C5CAE9");
    public Color Indigo300 = ColorTranslator.FromHtml("#7986CB");
    public Color Indigo400 = ColorTranslator.FromHtml("#5C6BC0");
    public Color Indigo500 = ColorTranslator.FromHtml("#3F51B5");
    public Color Indigo600 = ColorTranslator.FromHtml("#3949AB");
    public Color Indigo700 = ColorTranslator.FromHtml("#303F9F");
    public Color Indigo800 = ColorTranslator.FromHtml("#283593");
    public Color Indigo900 = ColorTranslator.FromHtml("#1A237E");
    public Color IndigoA100 = ColorTranslator.FromHtml("#8C9EFF");
    public Color IndigoA200 = ColorTranslator.FromHtml("#536DFE");
    public Color IndigoA400 = ColorTranslator.FromHtml("#3D5AFE");
    public Color IndigoA700 = ColorTranslator.FromHtml("#304FFE");

    //Blue
    public Color Blue50 = ColorTranslator.FromHtml("#E3F2FD");
    public Color Blue100 = ColorTranslator.FromHtml("#BBDEFB");
    public Color Blue200 = ColorTranslator.FromHtml("#90CAF9");
    public Color Blue300 = ColorTranslator.FromHtml("#64B5F6");
    public Color Blue400 = ColorTranslator.FromHtml("#42A5F5");
    public Color Blue500 = ColorTranslator.FromHtml("#2196F3");
    public Color Blue600 = ColorTranslator.FromHtml("#1E88E5");
    public Color Blue700 = ColorTranslator.FromHtml("#1976D2");
    public Color Blue800 = ColorTranslator.FromHtml("#1565C0");
    public Color Blue900 = ColorTranslator.FromHtml("#0D47A1");
    public Color BlueA100 = ColorTranslator.FromHtml("#82B1FF");
    public Color BlueA200 = ColorTranslator.FromHtml("#448AFF");
    public Color BlueA400 = ColorTranslator.FromHtml("#2979FF");
    public Color BlueA700 = ColorTranslator.FromHtml("#2962FF");

    //Light Blue
    public Color LightBlue50 = ColorTranslator.FromHtml("#E1F5FE");
    public Color LightBlue100 = ColorTranslator.FromHtml("#B3E5FC");
    public Color LightBlue200 = ColorTranslator.FromHtml("#81D4FA");
    public Color LightBlue300 = ColorTranslator.FromHtml("#4FC3F7");
    public Color LightBlue400 = ColorTranslator.FromHtml("#29B6F6");
    public Color LightBlue500 = ColorTranslator.FromHtml("#03A9F4");
    public Color LightBlue600 = ColorTranslator.FromHtml("#039BE5");
    public Color LightBlue700 = ColorTranslator.FromHtml("#0288D1");
    public Color LightBlue800 = ColorTranslator.FromHtml("#0277BD");
    public Color LightBlue900 = ColorTranslator.FromHtml("#01579B");
    public Color LightBlueA100 = ColorTranslator.FromHtml("#80D8FF");
    public Color LightBlueA200 = ColorTranslator.FromHtml("#40C4FF");
    public Color LightBlueA400 = ColorTranslator.FromHtml("#00B0FF");
    public Color LightBlueA700 = ColorTranslator.FromHtml("#0091EA");

    //Cyan
    public Color Cyan50 = ColorTranslator.FromHtml("#E0F7FA");
    public Color Cyan100 = ColorTranslator.FromHtml("#B2EBF2");
    public Color Cyan200 = ColorTranslator.FromHtml("#80DEEA");
    public Color Cyan300 = ColorTranslator.FromHtml("#4DD0E1");
    public Color Cyan400 = ColorTranslator.FromHtml("#26C6DA");
    public Color Cyan500 = ColorTranslator.FromHtml("#00BCD4");
    public Color Cyan600 = ColorTranslator.FromHtml("#00ACC1");
    public Color Cyan700 = ColorTranslator.FromHtml("#0097A7");
    public Color Cyan800 = ColorTranslator.FromHtml("#00838F");
    public Color Cyan900 = ColorTranslator.FromHtml("#006064");
    public Color CyanA100 = ColorTranslator.FromHtml("#84FFFF");
    public Color CyanA200 = ColorTranslator.FromHtml("#18FFFF");
    public Color CyanA400 = ColorTranslator.FromHtml("#00E5FF");
    public Color CyanA700 = ColorTranslator.FromHtml("#00B8D4");

    //Teal
    public Color Teal50 = ColorTranslator.FromHtml("#E0F2F1");
    public Color Teal100 = ColorTranslator.FromHtml("#B2DFDB");
    public Color Teal200 = ColorTranslator.FromHtml("#80CBC4");
    public Color Teal300 = ColorTranslator.FromHtml("#4DB6AC");
    public Color Teal400 = ColorTranslator.FromHtml("#26A69A");
    public Color Teal500 = ColorTranslator.FromHtml("#009688");
    public Color Teal600 = ColorTranslator.FromHtml("#00897B");
    public Color Teal700 = ColorTranslator.FromHtml("#00796B");
    public Color Teal800 = ColorTranslator.FromHtml("#00695C");
    public Color Teal900 = ColorTranslator.FromHtml("#004D40");
    public Color TealA100 = ColorTranslator.FromHtml("#A7FFEB");
    public Color TealA200 = ColorTranslator.FromHtml("#64FFDA");
    public Color TealA400 = ColorTranslator.FromHtml("#1DE9B6");
    public Color TealA700 = ColorTranslator.FromHtml("#00BFA5");

    //Green
    public Color Green50 = ColorTranslator.FromHtml("#E8F5E9");
    public Color Green100 = ColorTranslator.FromHtml("#C8E6C9");
    public Color Green200 = ColorTranslator.FromHtml("#A5D6A7");
    public Color Green300 = ColorTranslator.FromHtml("#81C784");
    public Color Green400 = ColorTranslator.FromHtml("#66BB6A");
    public Color Green500 = ColorTranslator.FromHtml("#4CAF50");
    public Color Green600 = ColorTranslator.FromHtml("#43A047");
    public Color Green700 = ColorTranslator.FromHtml("#388E3C");
    public Color Green800 = ColorTranslator.FromHtml("#2E7D32");
    public Color Green900 = ColorTranslator.FromHtml("#1B5E20");
    public Color GreenA100 = ColorTranslator.FromHtml("#B9F6CA");
    public Color GreenA200 = ColorTranslator.FromHtml("#69F0AE");
    public Color GreenA400 = ColorTranslator.FromHtml("#00E676");
    public Color GreenA700 = ColorTranslator.FromHtml("#00C853");

    //Light Green
    public Color LightGreen50 = ColorTranslator.FromHtml("#F1F8E9");
    public Color LightGreen100 = ColorTranslator.FromHtml("#DCEDC8");
    public Color LightGreen200 = ColorTranslator.FromHtml("#C5E1A5");
    public Color LightGreen300 = ColorTranslator.FromHtml("#AED581");
    public Color LightGreen400 = ColorTranslator.FromHtml("#9CCC65");
    public Color LightGreen500 = ColorTranslator.FromHtml("#8BC34A");
    public Color LightGreen600 = ColorTranslator.FromHtml("#7CB342");
    public Color LightGreen700 = ColorTranslator.FromHtml("#689F38");
    public Color LightGreen800 = ColorTranslator.FromHtml("#689F38");
    public Color LightGreen900 = ColorTranslator.FromHtml("#33691E");
    public Color LightGreenA100 = ColorTranslator.FromHtml("#CCFF90");
    public Color LightGreenA200 = ColorTranslator.FromHtml("#B2FF59");
    public Color LightGreenA400 = ColorTranslator.FromHtml("#76FF03");
    public Color LightGreenA700 = ColorTranslator.FromHtml("#64DD17");

    //Lime
    public Color Lime50 = ColorTranslator.FromHtml("#F9FBE7");
    public Color Lime100 = ColorTranslator.FromHtml("#F0F4C3");
    public Color Lime200 = ColorTranslator.FromHtml("#E6EE9C");
    public Color Lime300 = ColorTranslator.FromHtml("#DCE775");
    public Color Lime400 = ColorTranslator.FromHtml("#D4E157");
    public Color Lime500 = ColorTranslator.FromHtml("#CDDC39");
    public Color Lime600 = ColorTranslator.FromHtml("#C0CA33");
    public Color Lime700 = ColorTranslator.FromHtml("#AFB42B");
    public Color Lime800 = ColorTranslator.FromHtml("#9E9D24");
    public Color Lime900 = ColorTranslator.FromHtml("#827717");
    public Color LimeA100 = ColorTranslator.FromHtml("#F4FF81");
    public Color LimeA200 = ColorTranslator.FromHtml("#EEFF41");
    public Color LimeA400 = ColorTranslator.FromHtml("#C6FF00");
    public Color LimeA700 = ColorTranslator.FromHtml("#AEEA00");

    //Yellow
    public Color Yellow50 = ColorTranslator.FromHtml("#FFFDE7");
    public Color Yellow100 = ColorTranslator.FromHtml("#FFF9C4");
    public Color Yellow200 = ColorTranslator.FromHtml("#FFF59D");
    public Color Yellow300 = ColorTranslator.FromHtml("#FFF176");
    public Color Yellow400 = ColorTranslator.FromHtml("#FFEE58");
    public Color Yellow500 = ColorTranslator.FromHtml("#FFEB3B");
    public Color Yellow600 = ColorTranslator.FromHtml("#FDD835");
    public Color Yellow700 = ColorTranslator.FromHtml("#FBC02D");
    public Color Yellow800 = ColorTranslator.FromHtml("#F9A825");
    public Color Yellow900 = ColorTranslator.FromHtml("#F57F17");
    public Color YellowA100 = ColorTranslator.FromHtml("#FFFF8D");
    public Color YellowA200 = ColorTranslator.FromHtml("#FFFF00");
    public Color YellowA400 = ColorTranslator.FromHtml("#FFEA00");
    public Color YellowA700 = ColorTranslator.FromHtml("#FFD600");

    //Amber
    public Color Amber50 = ColorTranslator.FromHtml("#FFF8E1");
    public Color Amber100 = ColorTranslator.FromHtml("#FFECB3");
    public Color Amber200 = ColorTranslator.FromHtml("#FFE082");
    public Color Amber300 = ColorTranslator.FromHtml("#FFD54F");
    public Color Amber400 = ColorTranslator.FromHtml("#FFCA28");
    public Color Amber500 = ColorTranslator.FromHtml("#FFC107");
    public Color Amber600 = ColorTranslator.FromHtml("#FFB300");
    public Color Amber700 = ColorTranslator.FromHtml("#FFA000");
    public Color Amber800 = ColorTranslator.FromHtml("#FF8F00");
    public Color Amber900 = ColorTranslator.FromHtml("#FF6F00");
    public Color AmberA100 = ColorTranslator.FromHtml("#FFE57F");
    public Color AmberA200 = ColorTranslator.FromHtml("#FFD740");
    public Color AmberA400 = ColorTranslator.FromHtml("#FFC400");
    public Color AmberA700 = ColorTranslator.FromHtml("#FFAB00");

    //Orange
    public Color Orange50 = ColorTranslator.FromHtml("#FFF3E0");
    public Color Orange100 = ColorTranslator.FromHtml("#FFE0B2");
    public Color Orange200 = ColorTranslator.FromHtml("#FFCC80");
    public Color Orange300 = ColorTranslator.FromHtml("#FFB74D");
    public Color Orange400 = ColorTranslator.FromHtml("#FFA726");
    public Color Orange500 = ColorTranslator.FromHtml("#FF9800");
    public Color Orange600 = ColorTranslator.FromHtml("#FB8C00");
    public Color Orange700 = ColorTranslator.FromHtml("#F57C00");
    public Color Orange800 = ColorTranslator.FromHtml("#EF6C00");
    public Color Orange900 = ColorTranslator.FromHtml("#E65100");
    public Color OrangeA100 = ColorTranslator.FromHtml("#FFD180");
    public Color OrangeA200 = ColorTranslator.FromHtml("#FFAB40");
    public Color OrangeA400 = ColorTranslator.FromHtml("#FF9100");
    public Color OrangeA700 = ColorTranslator.FromHtml("#FF6D00");

    //Deep Orange
    public Color DeepOrange50 = ColorTranslator.FromHtml("#FBE9E7");
    public Color DeepOrange100 = ColorTranslator.FromHtml("#FFCCBC");
    public Color DeepOrange200 = ColorTranslator.FromHtml("#FFAB91");
    public Color DeepOrange300 = ColorTranslator.FromHtml("#FF8A65");
    public Color DeepOrange400 = ColorTranslator.FromHtml("#FF7043");
    public Color DeepOrange500 = ColorTranslator.FromHtml("#FF5722");
    public Color DeepOrange600 = ColorTranslator.FromHtml("#F4511E");
    public Color DeepOrange700 = ColorTranslator.FromHtml("#E64A19");
    public Color DeepOrange800 = ColorTranslator.FromHtml("#D84315");
    public Color DeepOrange900 = ColorTranslator.FromHtml("#BF360C");
    public Color DeepOrangeA100 = ColorTranslator.FromHtml("#FF9E80");
    public Color DeepOrangeA200 = ColorTranslator.FromHtml("#FF6E40");
    public Color DeepOrangeA400 = ColorTranslator.FromHtml("#FF3D00");
    public Color DeepOrangeA700 = ColorTranslator.FromHtml("#DD2C00");

    //Brown
    public Color Brown50 = ColorTranslator.FromHtml("#EFEBE9");
    public Color Brown100 = ColorTranslator.FromHtml("#D7CCC8");
    public Color Brown200 = ColorTranslator.FromHtml("#BCAAA4");
    public Color Brown300 = ColorTranslator.FromHtml("#A1887F");
    public Color Brown400 = ColorTranslator.FromHtml("#8D6E63");
    public Color Brown500 = ColorTranslator.FromHtml("#795548");
    public Color Brown600 = ColorTranslator.FromHtml("#6D4C41");
    public Color Brown700 = ColorTranslator.FromHtml("#5D4037");
    public Color Brown800 = ColorTranslator.FromHtml("#4E342E");
    public Color Brown900 = ColorTranslator.FromHtml("#3E2723");

    //Grey
    public Color Grey50 = ColorTranslator.FromHtml("#3E2723");
    public Color Grey100 = ColorTranslator.FromHtml("#F5F5F5");
    public Color Grey200 = ColorTranslator.FromHtml("#EEEEEE");
    public Color Grey300 = ColorTranslator.FromHtml("#E0E0E0");
    public Color Grey400 = ColorTranslator.FromHtml("#BDBDBD");
    public Color Grey500 = ColorTranslator.FromHtml("#9E9E9E");
    public Color Grey600 = ColorTranslator.FromHtml("#757575");
    public Color Grey700 = ColorTranslator.FromHtml("#616161");
    public Color Grey800 = ColorTranslator.FromHtml("#424242");
    public Color Grey900 = ColorTranslator.FromHtml("#212121");

    //Blue Grey
    public Color BlueGrey50 = ColorTranslator.FromHtml("#ECEFF1");
    public Color BlueGrey100 = ColorTranslator.FromHtml("#CFD8DC");
    public Color BlueGrey200 = ColorTranslator.FromHtml("#B0BEC5");
    public Color BlueGrey300 = ColorTranslator.FromHtml("#90A4AE");
    public Color BlueGrey400 = ColorTranslator.FromHtml("#78909C");
    public Color BlueGrey500 = ColorTranslator.FromHtml("#607D8B");
    public Color BlueGrey600 = ColorTranslator.FromHtml("#546E7A");
    public Color BlueGrey700 = ColorTranslator.FromHtml("#455A64");
    public Color BlueGrey800 = ColorTranslator.FromHtml("#37474F");
    public Color BlueGrey900 = ColorTranslator.FromHtml("#263238");
}

internal class FlatUI
{
    public Color Turquoise = ColorTranslator.FromHtml("#1ABC9C");
    public Color Greensea = ColorTranslator.FromHtml("#16A085");
    public Color Emerland = ColorTranslator.FromHtml("#2ECC71");
    public Color Nephritis = ColorTranslator.FromHtml("#27AE60");
    public Color Peterriver = ColorTranslator.FromHtml("#3498DB");
    public Color Belizehole = ColorTranslator.FromHtml("#2980B9");
    public Color Amethyst = ColorTranslator.FromHtml("#9B59B6");
    public Color Wisteria = ColorTranslator.FromHtml("#8E44AD");
    public Color Sunflower = ColorTranslator.FromHtml("#F1C40F");
    public Color Orange = ColorTranslator.FromHtml("#F39C12");
    public Color Carrot = ColorTranslator.FromHtml("#E67E22");
    public Color Pumpkin = ColorTranslator.FromHtml("#D35400");
    public Color Alizarin = ColorTranslator.FromHtml("#E74C3C");
    public Color Pomegranate = ColorTranslator.FromHtml("#C0392B");
    public Color Clouds = ColorTranslator.FromHtml("#ECF0F1");
    public Color Silver = ColorTranslator.FromHtml("#BDC3C7");
    public Color Concrete = ColorTranslator.FromHtml("#95A5A6");
    public Color Asbestos = ColorTranslator.FromHtml("#7F8C8D");
    public Color Wetasphalt = ColorTranslator.FromHtml("#34495E");
    public Color Midnightblue = ColorTranslator.FromHtml("#2C3E50");
}

internal class Social
{
    public Color Facebook = ColorTranslator.FromHtml("#1877F2");
    public Color Messenger = ColorTranslator.FromHtml("#0099FF");
    public Color Twitter = ColorTranslator.FromHtml("#1DA1F2");
    public Color LinkedIn = ColorTranslator.FromHtml("#0A66C2");
    public Color Skype = ColorTranslator.FromHtml("#00AFF0");
    public Color Dropbox = ColorTranslator.FromHtml("#0061FF");
    public Color Wordpress = ColorTranslator.FromHtml("#21759B");
    public Color Vimeo = ColorTranslator.FromHtml("#1AB7EA");
    public Color SlideShare = ColorTranslator.FromHtml("#0077B5");
    public Color VK = ColorTranslator.FromHtml("#4C75A3");
    public Color Tumblr = ColorTranslator.FromHtml("#34465D");
    public Color Yahoo = ColorTranslator.FromHtml("#410093");
    public Color Pinterest = ColorTranslator.FromHtml("#BD081C");
    public Color Youtube = ColorTranslator.FromHtml("#CD201F");
    public Color Reddit = ColorTranslator.FromHtml("#FF5700");
    public Color Quora = ColorTranslator.FromHtml("#B92B27");
    public Color Yelp = ColorTranslator.FromHtml("#AF0606");
    public Color Weibo = ColorTranslator.FromHtml("#DF2029");
    public Color ProductHunt = ColorTranslator.FromHtml("#DA552F");
    public Color HackerNews = ColorTranslator.FromHtml("#FF6600");
    public Color Soundcloud = ColorTranslator.FromHtml("#FF3300");
    public Color Blogger = ColorTranslator.FromHtml("#F57D00");
    public Color SnapChat = ColorTranslator.FromHtml("#FFFC00");
    public Color WhatsApp = ColorTranslator.FromHtml("#25D366");
    public Color WeChat = ColorTranslator.FromHtml("#09B83E");
    public Color Line = ColorTranslator.FromHtml("#00C300");
    public Color Medium = ColorTranslator.FromHtml("#02B875");
    public Color Vine = ColorTranslator.FromHtml("#00B489");
    public Color Slack = ColorTranslator.FromHtml("#3AAF85");
    public Color Instagram = ColorTranslator.FromHtml("#E4405F");
    public Color Dribbble = ColorTranslator.FromHtml("#EA4C89");
    public Color Flickr = ColorTranslator.FromHtml("#FF0084");
    public Color FourSquare = ColorTranslator.FromHtml("#F94877");
    public Color TikTok = ColorTranslator.FromHtml("#EE1D51");
    public Color Behance = ColorTranslator.FromHtml("#131418");
}

internal class Metro
{
    public Color Lime = ColorTranslator.FromHtml("#A4C400");
    public Color Green = ColorTranslator.FromHtml("#60A917");
    public Color Emerald = ColorTranslator.FromHtml("#008A00");
    public Color Teal = ColorTranslator.FromHtml("#00ABA9");
    public Color Cyan = ColorTranslator.FromHtml("#1BA1E2");
    public Color Cobalt = ColorTranslator.FromHtml("#0050EF");
    public Color Indigo = ColorTranslator.FromHtml("#6A00FF");
    public Color Violet = ColorTranslator.FromHtml("#AA00FF");
    public Color Pink = ColorTranslator.FromHtml("#F472D0");
    public Color Magenta = ColorTranslator.FromHtml("#D80073");
    public Color Crimson = ColorTranslator.FromHtml("#A20025");
    public Color Red = ColorTranslator.FromHtml("#E51400");
    public Color Orange = ColorTranslator.FromHtml("#FA6800");
    public Color Amber = ColorTranslator.FromHtml("#F0A30A");
    public Color Yellow = ColorTranslator.FromHtml("#E3C800");
    public Color Brown = ColorTranslator.FromHtml("#825A2C");
    public Color Olive = ColorTranslator.FromHtml("#6D8764");
    public Color Steel = ColorTranslator.FromHtml("#647687");
    public Color Mauve = ColorTranslator.FromHtml("#76608A");
    public Color Sienna = ColorTranslator.FromHtml("#A0522D");
}

internal class HTML
{
    public Color white = ColorTranslator.FromHtml("#FFFFFF");
    public Color whitesmoke = ColorTranslator.FromHtml("#F5F5F5");
    public Color gainsboro = ColorTranslator.FromHtml("#DCDCDC");
    public Color lightgrey = ColorTranslator.FromHtml("#D3D3D3");
    public Color silver = ColorTranslator.FromHtml("#C0C0C0");
    public Color darkgrey = ColorTranslator.FromHtml("#A9A9A9");
    public Color grey = ColorTranslator.FromHtml("#808080");
    public Color dimgrey = ColorTranslator.FromHtml("#696969");
    public Color black = ColorTranslator.FromHtml("#000000");
    public Color mistyrose = ColorTranslator.FromHtml("#FFE4E1");
    public Color lightcoral = ColorTranslator.FromHtml("#F08080");
    public Color salmon = ColorTranslator.FromHtml("#FA8072");
    public Color rosybrown = ColorTranslator.FromHtml("#BC8F8F");
    public Color tomato = ColorTranslator.FromHtml("#FF6347");
    public Color indianred = ColorTranslator.FromHtml("#CD5C5C");
    public Color red = ColorTranslator.FromHtml("#FF0000");
    public Color firebrick = ColorTranslator.FromHtml("#B22222");
    public Color brown = ColorTranslator.FromHtml("#A52A2A");
    public Color darkred = ColorTranslator.FromHtml("#8B0000");
    public Color maroon = ColorTranslator.FromHtml("#800000");
    public Color seashell = ColorTranslator.FromHtml("#FFF5EE");
    public Color peachpuff = ColorTranslator.FromHtml("#FFDAB9");
    public Color lightsalmon = ColorTranslator.FromHtml("#FFA07A");
    public Color darksalmon = ColorTranslator.FromHtml("#E9967A");
    public Color sandybrown = ColorTranslator.FromHtml("#F4A460");
    public Color coral = ColorTranslator.FromHtml("#FF7F50");
    public Color peru = ColorTranslator.FromHtml("#CD853F");
    public Color orangered = ColorTranslator.FromHtml("#FF4500");
    public Color chocolate = ColorTranslator.FromHtml("#D2691E");
    public Color sienna = ColorTranslator.FromHtml("#A0522D");
    public Color saddlebrown = ColorTranslator.FromHtml("#8B4513");
    public Color snow = ColorTranslator.FromHtml("#FFFAFA");
    public Color floralwhite = ColorTranslator.FromHtml("#FFFAF0");
    public Color oldlace = ColorTranslator.FromHtml("#FDF5E6");
    public Color linen = ColorTranslator.FromHtml("#FAF0E6");
    public Color papayawhip = ColorTranslator.FromHtml("#FFEFD5");
    public Color antiquewhite = ColorTranslator.FromHtml("#FAEBD7");
    public Color blanchedalmond = ColorTranslator.FromHtml("#FFEBCD");
    public Color bisque = ColorTranslator.FromHtml("#FFE4C4");
    public Color moccasin = ColorTranslator.FromHtml("#FFE4B5");
    public Color navajowhite = ColorTranslator.FromHtml("#FFDEAD");
    public Color wheat = ColorTranslator.FromHtml("#F5DEB3");
    public Color burlywood = ColorTranslator.FromHtml("#DEB887");
    public Color tan = ColorTranslator.FromHtml("#D2B48C");
    public Color darkorange = ColorTranslator.FromHtml("#FF8C00");
    public Color orange = ColorTranslator.FromHtml("#FFA500");
    public Color goldenrod = ColorTranslator.FromHtml("#DAA520");
    public Color darkgoldenrod = ColorTranslator.FromHtml("#B8860B");
    public Color cornsilk = ColorTranslator.FromHtml("#FFF8DC");
    public Color lemonchiffon = ColorTranslator.FromHtml("#FFFACD");
    public Color palegoldenrod = ColorTranslator.FromHtml("#EEE8AA");
    public Color khaki = ColorTranslator.FromHtml("#F0E68C");
    public Color darkkhaki = ColorTranslator.FromHtml("#BDB76B");
    public Color gold = ColorTranslator.FromHtml("#FFD700");
    public Color ivory = ColorTranslator.FromHtml("#FFFFF0");
    public Color lightyellow = ColorTranslator.FromHtml("#FFFFE0");
    public Color beige = ColorTranslator.FromHtml("#F5F5DC");
    public Color lightgoldenrodyellow = ColorTranslator.FromHtml("#FAFAD2");
    public Color yellow = ColorTranslator.FromHtml("#FFFF00");
    public Color olive = ColorTranslator.FromHtml("#808000");
    public Color greenyellow = ColorTranslator.FromHtml("#ADFF2F");
    public Color yellowgreen = ColorTranslator.FromHtml("#9ACD32");
    public Color olivedrab = ColorTranslator.FromHtml("#6B8E23");
    public Color darkolivegreen = ColorTranslator.FromHtml("#556B2F");
    public Color chartreuse = ColorTranslator.FromHtml("#7FFF00");
    public Color lawngreen = ColorTranslator.FromHtml("#7CFC00");
    public Color honeydew = ColorTranslator.FromHtml("#F0FFF0");
    public Color palegreen = ColorTranslator.FromHtml("#98FB98");
    public Color lightgreen = ColorTranslator.FromHtml("#90EE90");
    public Color darkseagreen = ColorTranslator.FromHtml("#8FBC8F");
    public Color lime = ColorTranslator.FromHtml("#00FF00");
    public Color limegreen = ColorTranslator.FromHtml("#32CD32");
    public Color forestgreen = ColorTranslator.FromHtml("#228B22");
    public Color green = ColorTranslator.FromHtml("#008000");
    public Color darkgreen = ColorTranslator.FromHtml("#006400");
    public Color springgreen = ColorTranslator.FromHtml("#00FF7F");
    public Color mediumseagreen = ColorTranslator.FromHtml("#3CB371");
    public Color seagreen = ColorTranslator.FromHtml("#2E8B57");
    public Color mintcream = ColorTranslator.FromHtml("#F5FFFA");
    public Color aquamarine = ColorTranslator.FromHtml("#7FFFD4");
    public Color mediumaquamarine = ColorTranslator.FromHtml("#66CDAA");
    public Color mediumspringgreen = ColorTranslator.FromHtml("#00FA9A");
    public Color turquoise = ColorTranslator.FromHtml("#40E0D0");
    public Color mediumturquoise = ColorTranslator.FromHtml("#48D1CC");
    public Color lightseagreen = ColorTranslator.FromHtml("#20B2AA");
    public Color azure = ColorTranslator.FromHtml("#F0FFFF");
    public Color lightcyan = ColorTranslator.FromHtml("#E0FFFF");
    public Color paleturquoise = ColorTranslator.FromHtml("#AFEEEE");
    public Color powderblue = ColorTranslator.FromHtml("#B0E0E6");
    public Color lightblue = ColorTranslator.FromHtml("#ADD8E6");
    public Color cyan = ColorTranslator.FromHtml("#00FFFF");
    public Color cadetblue = ColorTranslator.FromHtml("#5F9EA0");
    public Color darkturquoise = ColorTranslator.FromHtml("#00CED1");
    public Color darkcyan = ColorTranslator.FromHtml("#008B8B");
    public Color teal = ColorTranslator.FromHtml("#008080");
    public Color darkslategrey = ColorTranslator.FromHtml("#2F4F4F");
    public Color aliceblue = ColorTranslator.FromHtml("#F0F8FF");
    public Color lightskyblue = ColorTranslator.FromHtml("#87CEFA");
    public Color skyblue = ColorTranslator.FromHtml("#87CEEB");
    public Color dodgerblue = ColorTranslator.FromHtml("#1E90FF");
    public Color deepskyblue = ColorTranslator.FromHtml("#00BFFF");
    public Color steelblue = ColorTranslator.FromHtml("#4682B4");
    public Color lightsteelblue = ColorTranslator.FromHtml("#B0C4DE");
    public Color cornflowerblue = ColorTranslator.FromHtml("#6495ED");
    public Color royalblue = ColorTranslator.FromHtml("#4169E1");
    public Color lightslategrey = ColorTranslator.FromHtml("#778899");
    public Color slategrey = ColorTranslator.FromHtml("#708090");
    public Color lavender = ColorTranslator.FromHtml("#E6E6FA");
    public Color mediumslateblue = ColorTranslator.FromHtml("#7B68EE");
    public Color slateblue = ColorTranslator.FromHtml("#6A5ACD");
    public Color blue = ColorTranslator.FromHtml("#0000FF");
    public Color mediumblue = ColorTranslator.FromHtml("#0000CD");
    public Color darkslateblue = ColorTranslator.FromHtml("#483D8B");
    public Color darkblue = ColorTranslator.FromHtml("#00008B");
    public Color midnightblue = ColorTranslator.FromHtml("#191970");
    public Color navy = ColorTranslator.FromHtml("#000080");
    public Color mediumpurple = ColorTranslator.FromHtml("#9370DB");
    public Color ghostwhite = ColorTranslator.FromHtml("#F8F8FF");
    public Color blueviolet = ColorTranslator.FromHtml("#8A2BE2");
    public Color darkorchid = ColorTranslator.FromHtml("#9932CC");
    public Color darkviolet = ColorTranslator.FromHtml("#9400D3");
    public Color indigo = ColorTranslator.FromHtml("#4B0082");
    public Color mediumorchid = ColorTranslator.FromHtml("#BA55D3");
    public Color thistle = ColorTranslator.FromHtml("#D8BFD8");
    public Color plum = ColorTranslator.FromHtml("#DDA0DD");
    public Color violet = ColorTranslator.FromHtml("#EE82EE");
    public Color orchid = ColorTranslator.FromHtml("#DA70D6");
    public Color magenta = ColorTranslator.FromHtml("#FF00FF");
    public Color darkmagenta = ColorTranslator.FromHtml("#8B008B");
    public Color purple = ColorTranslator.FromHtml("#800080");
    public Color deeppink = ColorTranslator.FromHtml("#FF1493");
    public Color mediumvioletred = ColorTranslator.FromHtml("#C71585");
    public Color pink = ColorTranslator.FromHtml("#FFC0CB");
    public Color lightpink = ColorTranslator.FromHtml("#FFB6C1");
    public Color crimson = ColorTranslator.FromHtml("#DC143C");
    public Color lavenderblush = ColorTranslator.FromHtml("#FFF0F5");
    public Color hotpink = ColorTranslator.FromHtml("#FF69B4");
    public Color palevioletred = ColorTranslator.FromHtml("#DB7093");
}