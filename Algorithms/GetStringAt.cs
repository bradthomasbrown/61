partial class Algorithms {


unsafe public static string GetStringAt(ulong address) {
 string s = "";
 byte* ptr = (byte*)address;
 byte b = *ptr;
 for (; b != 0; b = *++ptr) s += (char)b;
 return s;
}


}

