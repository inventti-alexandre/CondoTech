﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Condominio.CrossCutting.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MensagensDoSistema {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MensagensDoSistema() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Condominio.CrossCutting.Resources.MensagensDoSistema", typeof(MensagensDoSistema).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Atenção usuário!.
        /// </summary>
        public static string Atencao {
            get {
                return ResourceManager.GetString("Atencao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ops! Algo inesperado aconteceu.
        /// </summary>
        public static string Erro {
            get {
                return ResourceManager.GetString("Erro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verifique se o arquivo escolhido é realmente uma imagem.
        /// </summary>
        public static string ImagemInvalida {
            get {
                return ResourceManager.GetString("ImagemInvalida", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Não foi possível realizar login,  verifique sua senha ou informe o Administrador do sistema.
        /// </summary>
        public static string LoginNaoPermitido {
            get {
                return ResourceManager.GetString("LoginNaoPermitido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deseja realmente executar esta função!.
        /// </summary>
        public static string Questao {
            get {
                return ResourceManager.GetString("Questao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operação realizada!.
        /// </summary>
        public static string Sucesso {
            get {
                return ResourceManager.GetString("Sucesso", resourceCulture);
            }
        }
    }
}