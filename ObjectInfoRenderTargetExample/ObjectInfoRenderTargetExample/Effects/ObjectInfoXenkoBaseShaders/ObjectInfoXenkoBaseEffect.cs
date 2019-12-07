﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

using Xenko.Rendering.Data;
using Xenko.Rendering.Materials;
namespace ObjectInfoRenderTargetExample.Effects
{
    internal static partial class ShaderMixins
    {
        internal partial class ObjectInfoXenkoBaseEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                context.Mixin(mixin, "OioShaderBase");
                context.Mixin(mixin, "OioTransformationBase");
                context.Mixin(mixin, "NormalStream");
                context.Mixin(mixin, "OioTransformationWAndVP");
                if (context.GetParam(MaterialKeys.HasNormalMap))
                {
                    context.Mixin(mixin, "OioNormalFromNormalMapping");
                }
                else
                {
                    context.Mixin(mixin, "OioNormalFromMesh");
                }
                if (context.GetParam(MaterialKeys.HasSkinningPosition))
                {
                    mixin.AddMacro("SkinningMaxBones", context.GetParam(MaterialKeys.SkinningMaxBones));
                    context.Mixin(mixin, "OioTransformationSkinning");
                    if (context.GetParam(MaterialKeys.HasSkinningNormal))
                    {
                        context.Mixin(mixin, "OioNormalMeshSkinning");
                    }
                    if (context.GetParam(MaterialKeys.HasSkinningTangent))
                    {
                        context.Mixin(mixin, "OioTangentMeshSkinning");
                    }
                    if (context.GetParam(MaterialKeys.HasSkinningNormal))
                    {
                        if (context.GetParam(MaterialKeys.HasNormalMap))
                        {
                            context.Mixin(mixin, "OioNormalVSSkinningNormalMapping");
                        }
                        else
                        {
                            context.Mixin(mixin, "OioNormalVSSkinningFromMesh");
                        }
                    }
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("ObjectInfoXenkoBaseEffect", new ObjectInfoXenkoBaseEffect());
            }
        }
    }
}