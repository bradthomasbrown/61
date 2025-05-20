namespace Ntdll {
public partial class ObjectAttributes {


unsafe public struct _ {
 public uint             Length                  ;
 public ulong            RootDirectory           ;
 public UnicodeString._* ObjectName              ;
 public Attributes       Attributes              ;
 public ulong            SecurityDescriptor      ;
 public ulong            SecurityQualityOfService;
}


} }