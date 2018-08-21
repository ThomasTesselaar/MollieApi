namespace Mollie.Api.Models.Issuer {
	/// <summary>
	///     URLs of images representing the issuer.
	/// </summary>
	public class IssuerResponseImage {
		/// <summary>
		///     The URL for an issuer icon of 40x40 pixels.
		/// </summary>
		public string Normal { get; set; }

		/// <summary>
		///     The URL for an issuer icon of 80x80 pixels.
		/// </summary>
		public string Bigger { get; set; }

		public override string ToString() {
			return this.Normal;
		}
	}
}