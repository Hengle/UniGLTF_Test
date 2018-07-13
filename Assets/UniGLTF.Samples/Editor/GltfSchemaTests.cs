﻿using NUnit.Framework;
using System.IO;
using UniJSON;
using UnityEngine;


namespace UniGLTF
{
    public class GltfSchemaTests
    {
        static IFileSystemAccessor m_schemaDir;
        static IFileSystemAccessor SchemaDir
        {
            get
            {
                if (m_schemaDir == null)
                {
                    var path = Path.GetFullPath(Application.dataPath + "/../glTF/specification/2.0/schema");
                    m_schemaDir = new FileSystemAccessor(path);
                }
                return m_schemaDir;
            }
        }

        [Test]
        public void Accessor()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("accessor.schema.json"));
            Assert.AreEqual("Accessor", fromSchema.Title);
            Assert.AreEqual("object", fromSchema.Type);
            Assert.AreEqual("integer", fromSchema.Properties["bufferView"].Type);
            Assert.AreEqual("integer", fromSchema.Properties["byteOffset"].Type);

            var fromClass = JsonSchema.Create<glTFAccessor>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void AccessorSparseIndices()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("accessor.sparse.indices.schema.json"));
            var fromClass = JsonSchema.Create<glTFSparseIndices>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void AccessorSparse()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("accessor.sparse.schema.json"));
            var fromClass = JsonSchema.Create<glTFSparse>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void AccessorSparseValues()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("accessor.sparse.values.schema.json"));
            var fromClass = JsonSchema.Create<glTFSparseValues>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void AnimationChannel()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("animation.channel.schema.json"));
            var fromClass = JsonSchema.Create<glTFAnimationChannel>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void AnimationChannelTarget()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("animation.channel.target.schema.json"));
            var fromClass = JsonSchema.Create<glTFAnimationTarget>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void AnimationSampler()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("animation.sampler.schema.json"));
            var fromClass = JsonSchema.Create<glTFAnimationSampler>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Animation()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("animation.schema.json"));
            var fromClass = JsonSchema.Create<glTFAnimation>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Asset()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("asset.schema.json"));
            var fromClass = JsonSchema.Create<glTFAssets>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Buffer()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("buffer.schema.json"));
            var fromClass = JsonSchema.Create<glTFBuffer>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void BufferView()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("bufferView.schema.json"));
            var fromClass = JsonSchema.Create<glTFBufferView>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Gltf()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("glTF.schema.json"));
            var fromClass = JsonSchema.Create<glTF>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Image()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("image.schema.json"));
            var fromClass = JsonSchema.Create<glTFImage>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void MaterialNormalTextureInfo()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("material.normalTextureInfo.schema.json"));
            var fromClass = JsonSchema.Create<glTFMaterialNormalTextureInfo>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void MaterialOcclusionTextureInfo()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("material.occlusionTextureInfo.schema.json"));
            var fromClass = JsonSchema.Create<glTFMaterialOcclusionTextureInfo>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void MaterialPbrMetallicRoughness()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("material.pbrMetallicRoughness.schema.json"));
            var fromClass = JsonSchema.Create<glTFPbrMetallicRoughness>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Material()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("material.schema.json"));
            var fromClass = JsonSchema.Create<glTFMaterial>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void MeshPrimitive()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("mesh.primitive.schema.json"));
            var fromClass = JsonSchema.Create<glTFPrimitives>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Mesh()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("mesh.schema.json"));
            var fromClass = JsonSchema.Create<glTFMesh>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Node()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("node.schema.json"));
            var fromClass = JsonSchema.Create<glTFNode>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Sampler()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("sampler.schema.json"));
            var fromClass = JsonSchema.Create<glTFTextureSampler>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Scene()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("scene.schema.json"));
            var fromClass = JsonSchema.Create<gltfScene>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Skin()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("skin.schema.json"));
            var fromClass = JsonSchema.Create<glTFSkin>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void Texture()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("texture.schema.json"));
            var fromClass = JsonSchema.Create<glTFTexture>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }

        [Test]
        public void TextureInfo()
        {
            var fromSchema = JsonSchema.ParseFromPath(SchemaDir.Get("textureInfo.schema.json"));
            var fromClass = JsonSchema.Create<glTFTextureInfo>();
            Assert.True(fromSchema.MatchProperties(fromClass));
        }
    }
}
