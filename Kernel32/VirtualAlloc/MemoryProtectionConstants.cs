namespace Kernel32 {
public partial class VirtualAlloc {


public enum MemoryProtectionConstants : uint {
 PAGE_NOACCESS          = 0x00000001,
 PAGE_READONLY          = 0x00000002,
 PAGE_READWRITE         = 0x00000004,
 PAGE_WRITECOPY         = 0x00000008,
 PAGE_EXECUTE           = 0x00000010,
 PAGE_EXECUTE_READ      = 0x00000020,
 PAGE_EXECUTE_READWRITE = 0x00000040,
 PAGE_EXECUTE_WRITECOPY = 0x00000080,
 PAGE_TARGETS_INVALID   = 0x40000000,
 PAGE_TARGETS_NO_UPDATE = 0x40000000
}


} }