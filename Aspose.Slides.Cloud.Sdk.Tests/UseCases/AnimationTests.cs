// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeTests.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using System.Collections.Generic;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class AnimationTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void AnimationGet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.GetAnimation(c_fileName, c_slideIndex, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
            SlideAnimation animationForShape = TestUtils.SlidesApi.GetAnimation(c_fileName, c_slideIndex, 3, password: c_password, folder: c_folderName);
            Assert.AreEqual(1, animationForShape.MainSequence.Count);
            Assert.AreEqual(0, animationForShape.InteractiveSequences.Count);
            SlideAnimation animationForParagraph = TestUtils.SlidesApi.GetAnimation(c_fileName, c_slideIndex, 3, 1, password: c_password, folder: c_folderName);
            Assert.AreEqual(0, animationForParagraph.MainSequence.Count);
        }

        [Test]
        public void AnimationSet()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation dto = new SlideAnimation
            {
                MainSequence = new List<Effect>
                {
                    new Effect { Type = Effect.TypeEnum.Blink, ShapeIndex = 2, ParagraphIndex = 1 },
                    new Effect
                    {
                        Type = Effect.TypeEnum.Box,
                        Subtype = Effect.SubtypeEnum.In,
                        PresetClassType = Effect.PresetClassTypeEnum.Entrance,
                        ShapeIndex = 4
                    }
                },
                InteractiveSequences = new List<InteractiveSequence> { }
            };
            SlideAnimation animation = TestUtils.SlidesApi.SetAnimation(c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(dto.MainSequence.Count, animation.MainSequence.Count);
            Assert.AreEqual(0, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationCreateEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Effect dto = new Effect { Type = Effect.TypeEnum.Blast, ShapeIndex = 3 };
            SlideAnimation animation = TestUtils.SlidesApi.CreateAnimationEffect(c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount + 1, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationCreateInteractiveSequence()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            InteractiveSequence dto = new InteractiveSequence
            {
                TriggerShapeIndex = 2,
                Effects = new List<Effect> { new Effect { Type = Effect.TypeEnum.Blast, ShapeIndex = 3 } }
            };
            SlideAnimation animation = TestUtils.SlidesApi.CreateAnimationInteractiveSequence(c_fileName, c_slideIndex, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount + 1, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationCreateInteractiveSequenceEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Effect dto = new Effect { Type = Effect.TypeEnum.Blast, ShapeIndex = 3 };
            SlideAnimation animation = TestUtils.SlidesApi.CreateAnimationInteractiveSequenceEffect(c_fileName, c_slideIndex, 1, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationUpdateEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Effect dto = new Effect { Type = Effect.TypeEnum.Blast, ShapeIndex = 3 };
            SlideAnimation animation = TestUtils.SlidesApi.UpdateAnimationEffect(c_fileName, c_slideIndex, 1, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationUpdateInteractiveSequenceEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            Effect dto = new Effect { Type = Effect.TypeEnum.Blast, ShapeIndex = 3 };
            SlideAnimation animation = TestUtils.SlidesApi.UpdateAnimationInteractiveSequenceEffect(c_fileName, c_slideIndex, 1, 1, dto, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationDelete()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.DeleteAnimation(c_fileName, c_slideIndex, password: c_password, folder: c_folderName);
            Assert.AreEqual(0, animation.MainSequence.Count);
            Assert.AreEqual(0, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationDeleteMainSequence()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.DeleteAnimationMainSequence(c_fileName, c_slideIndex, password: c_password, folder: c_folderName);
            Assert.AreEqual(0, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationDeleteMainSequenceEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.DeleteAnimationEffect(c_fileName, c_slideIndex, 1, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount - 1, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationDeleteInteractiveSequences()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.DeleteAnimationInteractiveSequences(c_fileName, c_slideIndex, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(0, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationDeleteInteractiveSequence()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.DeleteAnimationInteractiveSequence(c_fileName, c_slideIndex, 1, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount - 1, animation.InteractiveSequences.Count);
        }

        [Test]
        public void AnimationDeleteInteractiveSequenceEffect()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            SlideAnimation animation = TestUtils.SlidesApi.DeleteAnimationInteractiveSequenceEffect(c_fileName, c_slideIndex, 1, 1, password: c_password, folder: c_folderName);
            Assert.AreEqual(c_effectCount, animation.MainSequence.Count);
            Assert.AreEqual(c_interactiveSequenceCount, animation.InteractiveSequences.Count);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 1;
        const int c_effectCount = 1;
        const int c_interactiveSequenceCount = 1;
    }
}
