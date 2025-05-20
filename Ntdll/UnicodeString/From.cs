namespace Ntdll {
partial class UnicodeString {


public unsafe static ulong From(Mallocator m, string s) {
 ulong buffer = m.Alloc((uint)(s.Length+1<<1));
 for (int i = 0; i < s.Length; i++) *(byte*)(buffer+(ulong)(i<<1)) = (byte)s[i];
 ulong unicodeString = m.Alloc((uint)0x10, 8);
 *(ushort*)(unicodeString+0x0) = (ushort)(s.Length  <<1);
 *(ushort*)(unicodeString+0x2) = (ushort)(s.Length+1<<1);
 *(ulong *)(unicodeString+0x8) = buffer;
 return unicodeString;
}


} }