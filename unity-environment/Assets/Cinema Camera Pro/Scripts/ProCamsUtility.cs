using UnityEngine;

public class ProCamsUtility  
{
	/// <summary>
	/// Convert the specified val, from and to.
	/// </summary>
	/// <param name='val'>
	/// Value.
	/// </param>
	/// <param name='cfrom'>
	/// Original Unit.
	/// </param>
	/// <param name='to'>
	/// Desired Unit.
	/// </param>
	public static float Convert (float val, Units cfrom, Units to) {
		
		switch (cfrom) {
			case Units.Millimeter: {
				switch (to) {
					case Units.Centimeter: {
						// 1 to 0.1
						return val * 0.1f;
					}
					case Units.Meter: {
						// 1 to 0.001
						return val * 0.001f;
					}
					case Units.Inch: {
						// 1 to 0.0393701
						return val * 0.0393701f;
					}
					case Units.Foot: {
						// 1 to 0.00328084
						return val * 0.00328084f;
					}
				}
			}
			break;
			case Units.Centimeter: {
				switch (to) {
					case Units.Millimeter: {
						// 1 to 10
						return val * 10f;
					}
					case Units.Meter: {
						// 1 to 0.01
						return val * 0.01f;
					}
					case Units.Inch: {
						// 1 to 0.393701
						return val * 0.393701f;
					}
					case Units.Foot: {
						// 1 to 0.0328084
						return val * 0.0328084f;
					}
				}
			}
			break;
			case Units.Meter: {
				switch (to) {
					case Units.Centimeter: {
						// 1 to 100
						return val * 100f;
					}
					case Units.Millimeter: {
						// 1 to 1000
						return val * 1000f;
					}
					case Units.Inch: {
						// 1 to 39.3701
						return val * 39.3701f;
					}
					case Units.Foot: {
						// 1 to 3.28084
						return val * 3.28084f;
					}
				}
			}
			break;
			case Units.Inch: {
				switch (to) {
					case Units.Centimeter: {
						// 1 to 2.54
						return val * 2.54f;
					}
					case Units.Meter: {
						// 1 to 0.0254
						return val * 0.0254f;
					}
					case Units.Millimeter: {
						// 1 to 25.4	
						return val * 25.4f;
					}
					case Units.Foot: {
						// 1 to 0.0833333
						return val * 0.0833333f;
					}
				}
			}
			break;
			case Units.Foot: {
				switch (to) {
					case Units.Centimeter: {
						// 1 to 30.48
						return val * 30.48f;
					}
					case Units.Meter: {
						// 1 to 0.3048
						return val * 0.3048f;
					}
					case Units.Inch: {
						// 1 to 12
						return val * 12f;
					}
					case Units.Millimeter: {
						// 1 to 304.8
						return val * 304.8f;
					}
				}
			}
			break;
		}
		
		return 0;
	}

	public static float Truncate (float val, int decimalPlaces) {
		float dp = 1;
		
		for (int i = 0; i < decimalPlaces; i++) {
			dp *= 10;
		}
		
		
		val *= dp;
		val = Mathf.Floor(val);
		val /= dp;
		
		return val;
	}
}

public enum UnitOfMeasure
{
    Metric,
    Imperial
}

public enum Units 
{
	Millimeter,
	Centimeter,
	Meter,
	Inch,
	Foot
}
