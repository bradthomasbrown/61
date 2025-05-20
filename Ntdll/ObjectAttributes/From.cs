namespace Ntdll {
partial class ObjectAttributes {


public unsafe static ulong From(Mallocator m, string s) {
 ulong objectName = UnicodeString.From(m, s);
 ulong objectAttributes = m.Alloc((uint)0x30, 8);
 *(uint *)(objectAttributes+0x00) = 0x30                              ;
 *(ulong*)(objectAttributes+0x08) = 0                                 ;
 *(ulong*)(objectAttributes+0x10) = objectName                        ;
 *(uint *)(objectAttributes+0x18) = (uint)Attributes.OBJ_KERNEL_HANDLE;
 *(ulong*)(objectAttributes+0x20) = 0                                 ;
 *(ulong*)(objectAttributes+0x28) = 0                                 ;
 return objectAttributes;
}


} }