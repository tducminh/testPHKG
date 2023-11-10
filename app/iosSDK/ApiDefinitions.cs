using Foundation;

namespace Binding
{
	// @interface TriosProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface TriosProxy
	{
		// -(NSString * _Nonnull)initFor __attribute__((objc_method_family("none"))) __attribute__((warn_unused_result("")));
		[Export ("initFor")]
		string InitFor { get; }
	}
}
