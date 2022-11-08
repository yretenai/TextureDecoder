//This code is source generated. Do not edit manually.

using AssetRipper.TextureDecoder.Attributes;

namespace AssetRipper.TextureDecoder.Rgb.Formats
{
	[RgbaAttribute(RedChannel = true, GreenChannel = false, BlueChannel = false, AlphaChannel = false, FullyUtilizedChannels = true)]
	public partial struct ColorR16 : IColor<ushort>
	{
		public ushort R { get; set; }
		
		public ushort G 
		{
			get => ushort.MinValue;
			set { }
		}
		
		public ushort B 
		{
			get => ushort.MinValue;
			set { }
		}
		
		public ushort A 
		{
			get => ushort.MaxValue;
			set { }
		}
		
		public void GetChannels(out ushort r, out ushort g, out ushort b, out ushort a)
		{
			DefaultColorMethods.GetChannels(this, out r, out g, out b, out a);
			g = b = r;
		}
		
		public void SetChannels(ushort r, ushort g, ushort b, ushort a)
		{
			DefaultColorMethods.SetChannels(ref this, r, g, b, a);
		}
	}
}
