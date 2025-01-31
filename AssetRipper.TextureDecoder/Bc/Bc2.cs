﻿using AssetRipper.TextureDecoder.Rgb;
using AssetRipper.TextureDecoder.Rgb.Formats;

namespace AssetRipper.TextureDecoder.Bc;

public static class Bc2
{
	/// <summary>
	/// The size of an encoded block, in bytes.
	/// </summary>
	public const int BlockSize = 16;

	public static int Decompress(ReadOnlySpan<byte> input, int width, int height, out byte[] output)
	{
		output = new byte[width * height * Unsafe.SizeOf<ColorBGRA32>()];
		return Decompress(input, width, height, output);
	}

	[MethodImpl(MethodImplOptions.AggressiveOptimization)]
	public static int Decompress(ReadOnlySpan<byte> input, int width, int height, Span<byte> output)
	{
		int inputOffset = 0;
		for (int i = 0; i < height; i += 4)
		{
			for (int j = 0; j < width; j += 4)
			{
				int outputOffset = ((i * width) + j) * Unsafe.SizeOf<ColorRGBA<byte>>();
				BcHelpers.DecompressBc2(input.Slice(inputOffset), output.Slice(outputOffset), width * 4);
				inputOffset += BlockSize;
			}
		}
		return inputOffset;
	}

	internal static int GetCompressedSize(int w, int h) => ((w) >> 2) * ((h) >> 2) * BlockSize;
}
