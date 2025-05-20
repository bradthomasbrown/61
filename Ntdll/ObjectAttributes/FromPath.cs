namespace Ntdll {
partial class ObjectAttributes {


public static ulong FromPath(Mallocator m, string path) { return From(m, @"\??\"+path); }


} }