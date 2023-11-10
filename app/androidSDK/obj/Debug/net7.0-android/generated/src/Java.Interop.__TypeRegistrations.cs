using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/bglobal/base/base/common/usecase/executor",
					},
					new Converter<string, Type?>[]{
						lookup_com_bglobal_base_base_common_usecase_executor_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type? Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[]? package_com_bglobal_base_base_common_usecase_executor_mappings;
		static Type? lookup_com_bglobal_base_base_common_usecase_executor_package (string klass)
		{
			if (package_com_bglobal_base_base_common_usecase_executor_mappings == null) {
				package_com_bglobal_base_base_common_usecase_executor_mappings = new string[]{
					"com/bglobal/base/base/common/usecase/executor/TaskCallback$DefaultImpls:Com.Bglobal.Base.Base.Common.Usecase.Executor.ITaskCallback/DefaultImpls",
				};
			}

			return Lookup (package_com_bglobal_base_base_common_usecase_executor_mappings, klass);
		}
	}
}
