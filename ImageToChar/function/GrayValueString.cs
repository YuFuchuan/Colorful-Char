/* c_256是根据https://wenku.baidu.com/view/d6ebc602a1c7aa00b42acb67.html中给出的字符组改变而成(删去了其中需占两字符位的字符，并用相邻位的字符填充)
 * c_128,c_64,c_32,c_16,c_8,c_4均是从c_256中截取而成;
 */

namespace ImageToChar.function
{
    class GrayValueString
    {
        public readonly static string c_256 =
            "MMMMMMMMMMMMMMMMMMMMMNNNNNNNNNN#####$$$$$$$$&&&&&&" +
            "@@@@***QQQEEE¶¶HHKKRRRBBkkk%%DDWW889FF66hhgg55AAOO" +
            "OUXXZGGddPPSpmJI44LbTTVfq2n3YCyll[[]]uw7?aaxxevv{}" +
            "}}|||//\\ss1jj+rrzz===tttoocc))((<<>>>>>>iiiii!!!__" +
            "_~~~---;;;;`````::::''''',,,,,.......             " +
            "      ";

        public readonly static string c_128 =
            "MMMMMMMMMMMNNNNN##$$$$&&&@@**QEE¶HKRBkk%DW8F6hg5AO" +
            "OXZGdPpJ4LTVqnYyl[]w?axv{}||/s1jrz==toc)(<>>>iii!_" +
            "_~--;;``::''',,....         ";

        public readonly static string c_64 =
            "MMMMMMNN#$$&&@*E¶KBkD86gAOZdp4TqYl]?x{|/1r=tc(>>i!" +
            "_-;`:'',..    ";

        public readonly static string c_32 =
            "MMMN#$&*¶BD6AZpTY]x|1=c>i_;:'.  ";

        public readonly static string c_16 =
            "MM#&¶DApYx1ci;' ";

        public readonly static string c_8 =
            "M&Dpxc; ";

        public readonly static string c_4 =
            "&pc ";
    }
}
