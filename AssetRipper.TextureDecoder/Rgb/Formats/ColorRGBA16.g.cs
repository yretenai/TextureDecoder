// Auto-generated code. Do not modify manually.

namespace AssetRipper.TextureDecoder.Rgb.Formats
{
	public partial struct ColorRGBA16 : IColor<byte>
	{
		static bool IColor.HasRedChannel => true;
		static bool IColor.HasGreenChannel => true;
		static bool IColor.HasBlueChannel => true;
		static bool IColor.HasAlphaChannel => true;
		static bool IColor.ChannelsAreFullyUtilized => false;
		static Type IColor.ChannelType => typeof(byte);

		public override string ToString()
		{
			return $"{{ R: {R}, G: {G}, B: {B}, A: {A} }}";
		}
	}
}
