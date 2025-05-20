namespace Ntdll {
partial class NtOpenFile {


public enum Access : uint {
 FILE_READ_DATA        = 0x00000001,
 FILE_WRITE_DATA       = 0x00000002,
 FILE_APPEND_DATA      = 0x00000004,
 FILE_READ_EA          = 0x00000008,
 FILE_WRITE_EA         = 0x00000010,
 FILE_EXECUTE          = 0x00000020,
 FILE_READ_ATTRIBUTES  = 0x00000080,
 FILE_WRITE_ATTRIBUTES = 0x00000100,
 DELETE                = 0x00010000,
 READ_CONTROL          = 0x00020000,
 WRITE_DAC             = 0x00040000,
 WRITE_OWNER           = 0x00080000,
 SYNCHRONIZE           = 0x00100000
}


} }