//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.conf {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface KnowledgeBaseOptionsConfiguration {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lorg/drools/conf/KnowledgeBaseOption;)V")]
        void setOption(global::org.drools.conf.KnowledgeBaseOption par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/conf/MultiValueKnowledgeBaseOpti" +
            "on;")]
        global::org.drools.conf.MultiValueKnowledgeBaseOption getOption(global::java.lang.Class par0, global::java.lang.String par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Class;)Lorg/drools/conf/SingleValueKnowledgeBaseOption;")]
        global::org.drools.conf.SingleValueKnowledgeBaseOption getOption(global::java.lang.Class par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class KnowledgeBaseOptionsConfiguration_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.conf.KnowledgeBaseOptionsConfiguration), typeof(global::org.drools.conf.KnowledgeBaseOptionsConfiguration_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.conf.KnowledgeBaseOptionsConfiguration), typeof(global::org.drools.conf.KnowledgeBaseOptionsConfiguration_))]
    internal sealed partial class @__KnowledgeBaseOptionsConfiguration : global::java.lang.Object, global::org.drools.conf.KnowledgeBaseOptionsConfiguration {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _setOption0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOption1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOption2;
        
        private @__KnowledgeBaseOptionsConfiguration(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration.staticClass = @__class;
            global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration._setOption0 = @__env.GetMethodID(global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration.staticClass, "setOption", "(Lorg/drools/conf/KnowledgeBaseOption;)V");
            global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration._getOption1 = @__env.GetMethodID(global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration.staticClass, "getOption", "(Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/conf/MultiValueKnowledgeBaseOpti" +
                    "on;");
            global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration._getOption2 = @__env.GetMethodID(global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration.staticClass, "getOption", "(Ljava/lang/Class;)Lorg/drools/conf/SingleValueKnowledgeBaseOption;");
        }
        
        public void setOption(global::org.drools.conf.KnowledgeBaseOption par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration._setOption0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::org.drools.conf.KnowledgeBaseOption>(@__env, par0));
            }
        }
        
        public global::org.drools.conf.MultiValueKnowledgeBaseOption getOption(global::java.lang.Class par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.conf.MultiValueKnowledgeBaseOption>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration._getOption1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
            }
        }
        
        public global::org.drools.conf.SingleValueKnowledgeBaseOption getOption(global::java.lang.Class par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.conf.SingleValueKnowledgeBaseOption>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration._getOption2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__KnowledgeBaseOptionsConfiguration);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setOption", "setOption0", "(Lorg/drools/conf/KnowledgeBaseOption;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOption", "getOption1", "(Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/conf/MultiValueKnowledgeBaseOpti" +
                        "on;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOption", "getOption2", "(Ljava/lang/Class;)Lorg/drools/conf/SingleValueKnowledgeBaseOption;"));
            return methods;
        }
        
        private static void setOption0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lorg/drools/conf/KnowledgeBaseOption;)V
            // (Lorg/drools/conf/KnowledgeBaseOption;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::org.drools.conf.KnowledgeBaseOptionsConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.conf.KnowledgeBaseOptionsConfiguration>(@__env, @__obj);
            @__real.setOption(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.conf.KnowledgeBaseOption>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOption1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/conf/MultiValueKnowledgeBaseOption;
            // (Ljava/lang/Class;Ljava/lang/String;)Lorg/drools/conf/MultiValueKnowledgeBaseOption;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.conf.KnowledgeBaseOptionsConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.conf.KnowledgeBaseOptionsConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.conf.MultiValueKnowledgeBaseOption>(@__env, @__real.getOption(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, par1)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOption2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/lang/Class;)Lorg/drools/conf/SingleValueKnowledgeBaseOption;
            // (Ljava/lang/Class;)Lorg/drools/conf/SingleValueKnowledgeBaseOption;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.conf.KnowledgeBaseOptionsConfiguration @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.conf.KnowledgeBaseOptionsConfiguration>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.conf.SingleValueKnowledgeBaseOption>(@__env, @__real.getOption(global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.conf.@__KnowledgeBaseOptionsConfiguration(@__env);
            }
        }
    }
    #endregion
}
