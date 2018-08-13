//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 August 13 18:06:20 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial interface V : EmptyInterface
        {
        }

        [GeneratedCode("go2cs", "0.1.1.0")]
        public struct V<T> : V
        {
            private T m_target;

            public T Target => m_target;

            private delegate void NByVal(T value);
            private delegate void NByRef(ref T value);

            private static readonly NByVal s_NByVal;
            private static readonly NByRef s_NByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void N() => s_NByRef?.Invoke(ref m_target) ?? s_NByVal(m_target);

            private delegate void MByVal(T value);
            private delegate void MByRef(ref T value);

            private static readonly MByVal s_MByVal;
            private static readonly MByRef s_MByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void M() => s_MByRef?.Invoke(ref m_target) ?? s_MByVal(m_target);

            private delegate @string StringByVal(T value);
            private delegate @string StringByRef(ref T value);

            private static readonly StringByVal s_StringByVal;
            private static readonly StringByRef s_StringByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string String() => s_StringByRef?.Invoke(ref m_target) ?? s_StringByVal(m_target);

            private delegate @string ErrorByVal(T value);
            private delegate @string ErrorByRef(ref T value);

            private static readonly ErrorByVal s_ErrorByVal;
            private static readonly ErrorByRef s_ErrorByRef;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public @string Error() => s_ErrorByRef?.Invoke(ref m_target) ?? s_ErrorByVal(m_target);

            [DebuggerStepperBoundary]
            static V()
            {
                Type targetType = typeof(T);
                MethodInfo extensionMethod;

                extensionMethod = targetType.GetExtensionMethod("N");

                if ((object)extensionMethod != null)
                {
                    s_NByRef = extensionMethod.CreateStaticDelegate(typeof(NByRef)) as NByRef;

                    if ((object)s_NByRef == null)
                        s_NByVal = extensionMethod.CreateStaticDelegate(typeof(NByVal)) as NByVal;
                }

                if ((object)s_NByRef == null && (object)s_NByVal == null)
                    throw new NotImplementedException($"{targetType.Name} does not implement V.N method", new Exception("N"));

                extensionMethod = targetType.GetExtensionMethod("M");

                if ((object)extensionMethod != null)
                {
                    s_MByRef = extensionMethod.CreateStaticDelegate(typeof(MByRef)) as MByRef;

                    if ((object)s_MByRef == null)
                        s_MByVal = extensionMethod.CreateStaticDelegate(typeof(MByVal)) as MByVal;
                }

                if ((object)s_MByRef == null && (object)s_MByVal == null)
                    throw new NotImplementedException($"{targetType.Name} does not implement V.M method", new Exception("M"));

                extensionMethod = targetType.GetExtensionMethod("String");

                if ((object)extensionMethod != null)
                {
                    s_StringByRef = extensionMethod.CreateStaticDelegate(typeof(StringByRef)) as StringByRef;

                    if ((object)s_StringByRef == null)
                        s_StringByVal = extensionMethod.CreateStaticDelegate(typeof(StringByVal)) as StringByVal;
                }

                if ((object)s_StringByRef == null && (object)s_StringByVal == null)
                    throw new NotImplementedException($"{targetType.Name} does not implement V.String method", new Exception("String"));

                extensionMethod = targetType.GetExtensionMethod("Error");

                if ((object)extensionMethod != null)
                {
                    s_ErrorByRef = extensionMethod.CreateStaticDelegate(typeof(ErrorByRef)) as ErrorByRef;

                    if ((object)s_ErrorByRef == null)
                        s_ErrorByVal = extensionMethod.CreateStaticDelegate(typeof(ErrorByVal)) as ErrorByVal;
                }

                if ((object)s_ErrorByRef == null && (object)s_ErrorByVal == null)
                    throw new NotImplementedException($"{targetType.Name} does not implement V.Error method", new Exception("Error"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator V<T>(T target) => new V<T> { m_target = target };

            // Enable comparisons between nil and V<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(V<T> value, NilType nil) => Activator.CreateInstance<V<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(V<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, V<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, V<T> value) => value != nil;
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static V V_cast<T>(T target)
        {
            if (typeof(V).IsAssignableFrom(typeof(T)))
                return target as V;

            return (V<T>)target;
        }
    }
}

namespace go
{
    public partial class NilType
    {
        // Enable comparisons between nil and V interface
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(go.main_package.V value, NilType nil) => (object)value == null || Activator.CreateInstance(value.GetType()).Equals(value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(go.main_package.V value, NilType nil) => !(value == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, go.main_package.V value) => value == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, go.main_package.V value) => value != nil;
    }

    public static class main_VExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T TypeAssert<T>(this go.main_package.V target)
        {
            try
            {
                return ((go.main_package.V<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"panic: interface conversion: {target.GetType().FullName} is not {typeof(T).FullName}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool TryTypeAssert<T>(this go.main_package.V target, out T result)
        {
            try
            {
                result = target.TypeAssert<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default(T);
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object TypeAssert(this go.main_package.V target, Type type)
        {
            try
            {
                MethodInfo conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.main_package.V<>).GetExplicitGenericConversionOperator(type));

                if ((object)conversionOperator == null)
                    throw new PanicException($"panic: interface conversion: failed to create converter for {target.GetType().FullName} to {type.FullName}");

                dynamic result = conversionOperator.Invoke(null, new object[] { target });
                return result.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"panic: interface conversion: {target.GetType().FullName} is not {type.FullName}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.1.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool TryTypeAssert(this go.main_package.V target, Type type, out object result)
        {
            try
            {
                result = target.TypeAssert(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}