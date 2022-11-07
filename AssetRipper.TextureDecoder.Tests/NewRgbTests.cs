﻿using AssetRipper.TextureDecoder.Rgb;
using AssetRipper.TextureDecoder.Rgb.Formats;

namespace AssetRipper.TextureDecoder.Tests
{
	public sealed class NewRgbTests
	{
		[Test]
		public void ConvertA8Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.alpha8");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.A8ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorA8, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
		}

		[Test]
		public void ConvertARGB16Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.argb4444");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.ARGB16ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorARGB16, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
		}

		[Test]
		public void ConvertRGB24Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgb24");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.RGB24ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorRGB24, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
		}

		[Test]
		public void ConvertRGBA32Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgba32");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.RGBA32ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorRGBA32, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertARGB32Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.argb32");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.ARGB32ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorARGB32, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertRGB16Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgb565");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.RGB16ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorRGB16, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertR16Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.r16");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.R16ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorR16, ushort, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertRGBA16Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgba4444");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.RGBA16ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorRGBA16, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertRG16Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rg16");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.RG16ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorRG16, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertR8Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.r8");
			int totalBytesRead = 0;
			foreach (int size in new int[] { 256, 128, 64, 32, 16, 8, 4, 2, 1 }) //mip maps
			{
				int bytesRead = RgbConverter.R8ToBGRA32(data.Slice(totalBytesRead), size, size, out byte[] originalDecodedData);
				RgbConverter.Convert<ColorR8, byte, ColorBGRA32, byte>(data.Slice(totalBytesRead), size, size, out byte[] newDecodedData);
				totalBytesRead += bytesRead;
				Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
			}
			Assert.That(totalBytesRead, Is.EqualTo(data.Length));
		}

		[Test]
		public void ConvertRHalfTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rhalf");
			RgbConverter.RHalfToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorR16Half, Half, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGHalfTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rghalf");
			RgbConverter.RGHalfToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRG32Half, Half, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGBAHalfTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgbahalf");
			RgbConverter.RGBAHalfToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRGBA64Half, Half, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRFloatTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rfloat");
			RgbConverter.RFloatToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorR32Single, float, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGFloatTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgfloat");
			RgbConverter.RGFloatToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRG64Single, float, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGBAFloatTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgbafloat");
			RgbConverter.RGBAFloatToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRGBA128Single, float, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGB9e5FloatTest()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgb9e5float");
			RgbConverter.RGB9e5FloatToBGRA32(data, 256, 256, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRGB9e5, double, ColorBGRA32, byte>(data, 256, 256, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRG32Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rg32");
			RgbConverter.RG32ToBGRA32(data, 512, 512, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRG32, ushort, ColorBGRA32, byte>(data, 512, 512, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGB48Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgb48");
			RgbConverter.RGB48ToBGRA32(data, 512, 512, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRGB48, ushort, ColorBGRA32, byte>(data, 512, 512, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}

		[Test]
		public void ConvertRGBA64Test()
		{
			ReadOnlySpan<byte> data = File.ReadAllBytes(PathConstants.RgbTestFilesFolder + "test.rgba64");
			RgbConverter.RGBA64ToBGRA32(data, 512, 512, out byte[] originalDecodedData);
			RgbConverter.Convert<ColorRGBA64, ushort, ColorBGRA32, byte>(data, 512, 512, out byte[] newDecodedData);
			Assert.That(originalDecodedData, Is.EqualTo(newDecodedData));
		}
	}
}