using Ntdll;
namespace _3575_ {
public partial class Peb {

private static Peb._? _peb;
unsafe public static Peb._ GetPeb() {
 if (_peb == null) {
  Mallocator m_rwx = new Mallocator(protect : Kernel32.VirtualAlloc.MemoryProtectionConstants.PAGE_EXECUTE_READWRITE);
  _peb = *(Peb._*)GetPebAddress(m_rwx);
 }
 return (Peb._)_peb;
}


} }