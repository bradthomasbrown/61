namespace Ntdll {
partial class NtCreateSectionEx {


public enum Access : uint {
 SECTION_QUERY       = 0x00000001,
 SECTION_MAP_WRITE   = 0x00000002,
 SECTION_MAP_READ    = 0x00000004,
 SECTION_MAP_EXECUTE = 0x00000008,
 SECTION_EXTEND_SIZE = 0x00000010,
 DELETE              = 0x00010000,
 READ_CONTROL        = 0x00020000,
 WRITE_DAC           = 0x00040000,
 WRITE_OWNER         = 0x00080000,
 SYNCHRONIZE         = 0x00100000
}


} }