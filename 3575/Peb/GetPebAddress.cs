using Ntdll;
namespace _3575_ {
public partial class Peb {


unsafe public static ulong GetPebAddress(Mallocator m_rwx) {
 ulong ptr =  m_rwx.Alloc(9);
 ulong pebAddress;
 int i = 0; foreach (byte b in new byte[] {
        0x31, 0xc0,          // xor eax, eax
  0x65, 0x8b, 0x40, 0x60,    // mov eax,DWORD PTR gs:[rax+0x60]
        0x89, 0x01,          // mov DWORD PTR [rcx], eax
        0xc3                 // ret
 }) *(byte*)(m_rwx.Init + (ulong)i++) = b;
 NtQueueApcThreadEx2._(
  apcRoutine : m_rwx.Init        ,
  arg0       : (ulong)&pebAddress
 );
 return pebAddress;
}


} }