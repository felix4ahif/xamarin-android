using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Android.Build.Tests
{
	static class InlineData
	{
#if false // Java source with javadoc
		package com.xamarin.android.test.msbuildtest;

		public class JavaSourceJarTest
		{
			/**
			 * Returns greeting message.
			 * <p>
			 * Returns "Morning, ", "Hello, " or "Evening, " with name argument,
			 * depending on the argument hour.
			 * </p>
			 * @param name name to display.
			 * @param date time to determine the greeting message.
			 * @return the resulting message.
			 */
			public String greet (String name, java.util.Date date)
			{
				String head = date.getHours () < 11 ? "Morning, " : date.getHours () < 17 ? "Hello, " : "Evening, ";
				return head + name;
			}
		}
#endif

		public const string JavaSourcesJarBase64 = @"
UEsDBBQACAgIAC2gP0wAAAAAAAAAAAAAAAAJAAQATUVUQS1JTkYv/soAAAMAUEsHCAAAAAACAAAAAAAAAFBLAwQUAAgIC
AAtoD9MAAAAAAAAAAAAAAAAFAAAAE1FVEEtSU5GL01BTklGRVNULk1G803My0xLLS7RDUstKs7Mz7NSMNQz4OVyLkpNLE
lN0XWqBAlY6BnEG5oaKmj4FyUm56QqOOcXFeQXJZYA1WvycvFyAQBQSwcIlldz8EQAAABFAAAAUEsDBBQACAgIACqgP0w
AAAAAAAAAAAAAAAA7AAAAY29tL3hhbWFyaW4vYW5kcm9pZC90ZXN0L21zYnVpbGR0ZXN0L0phdmFTb3VyY2VKYXJUZXN0
LmphdmF1kc1uwjAMx+99CosTsCqI0yRgG4dNQki7jL2Aaaw2Wz4qJ2WbJt59SSgfQsyq4kb+2X/babH6xJqgckZ8o0FWV
qCV7JQUgXwQxm87pWX6nxdF2221qqDS6D2scYcb13FFa+T3CBS/BUSbjMfZwxjeKHRsPdRMFJStwZD3UU8cgUX7eM0OXh
3byJYwiN+KtHbRg2MYvOyoj8CXCg1YNATIdWfIhvJYSFJLViY1ZyE0ZwKa2O1ZenLWXrbIaA718hEcSOVbjT/iipEYYlj
1DAVioyxlnX+nXHKeLUNMvtO3qEn2/YY3gROSK8Kwv6XOSviIaxddUFo8p1ZSP6Oceth+sp5vCCU8ZELUFFZxeg/DESxg
OoWny0XD7JSb7FbGfco4vcbs8jHmp+R+zix8l/s9xPbFvvgDUEsHCDlC8jY2AQAAawIAAFBLAQIUABQACAgIAC2gP0wAA
AAAAgAAAAAAAAAJAAQAAAAAAAAAAAAAAAAAAABNRVRBLUlORi/+ygAAUEsBAhQAFAAICAgALaA/TJZXc/BEAAAARQAAAB
QAAAAAAAAAAAAAAAAAPQAAAE1FVEEtSU5GL01BTklGRVNULk1GUEsBAhQAFAAICAgAKqA/TDlC8jY2AQAAawIAADsAAAA
AAAAAAAAAAAAAwwAAAGNvbS94YW1hcmluL2FuZHJvaWQvdGVzdC9tc2J1aWxkdGVzdC9KYXZhU291cmNlSmFyVGVzdC5q
YXZhUEsFBgAAAAADAAMA5gAAAGICAAAAAA==";

		public const string JavaClassesJarBase64 = @"
UEsDBBQACAgIAO+EP0wAAAAAAAAAAAAAAAAJAAQATUVUQS1JTkYv/soAAAMAUEsHCAAAAAACAAAAAAAAAFBLAwQUAAgIC
ADvhD9MAAAAAAAAAAAAAAAAFAAAAE1FVEEtSU5GL01BTklGRVNULk1G803My0xLLS7RDUstKs7Mz7NSMNQz4OVyLkpNLE
lN0XWqBAlY6BnEG5oaKmj4FyUm56QqOOcXFeQXJZYA1WvycvFyAQBQSwcIlldz8EQAAABFAAAAUEsDBBQACAgIALOEP0w
AAAAAAAAAAAAAAAA8AAAAY29tL3hhbWFyaW4vYW5kcm9pZC90ZXN0L21zYnVpbGR0ZXN0L0phdmFTb3VyY2VKYXJUZXN0
LmNsYXNzbVHZSsNAFD1j2yStaW3rvlvX1i0g4osiuKLi8lARfHPaDCWaJiWdit/ji6/6UkHBD/CjxDupIloDucuZO+fMn
Hn/eHkDsIpCAp3oS6AfAwYGDQwZGNYxkoCmUA2jKozpGNcxwaBtOJ4jNxki+cIFQ3THtwVD17HjidNGtSSCc15yCYlVAi
Ekw1r++JrfcsvlXsUqysDxKustpCEd19rlUqwX2kcYkkXJyzcnvBYS6sgxJIp+IyiLfUcJ9B3RnhZwxINzUZfLisWEiaS
OSRNTmGaIn/iBR4SLdHT9QLiur6r43q34Rvv/am83HNcWgYkZzJqYQ54uUfar1h2vclq3uGcHvmNbkiStar2kxsO67UAM
6R/ys9K1KP+GWnoMqd9+MBgVIQ+IqR7afEiu81pNeDbD0j92ttv3dQVy0ZD+t0pP/h+fkYN6fvV1gCnvKKaoG6XMKMfmn
8GeqKBHpqiFYIRiGpmv0SvaGqW8sthER7rzHkY28oDusMuoLvqAWDZ2+grt8hn6UhPGAv1NxB9DWcWbIk4QYxeyGEc3Rc
BAJJXc0qmjw4eTvZ9QSwcINzBZxakBAAC1AgAAUEsBAhQAFAAICAgA74Q/TAAAAAACAAAAAAAAAAkABAAAAAAAAAAAAAA
AAAAAAE1FVEEtSU5GL/7KAABQSwECFAAUAAgICADvhD9Mlldz8EQAAABFAAAAFAAAAAAAAAAAAAAAAAA9AAAATUVUQS1J
TkYvTUFOSUZFU1QuTUZQSwECFAAUAAgICACzhD9MNzBZxakBAAC1AgAAPAAAAAAAAAAAAAAAAADDAAAAY29tL3hhbWFya
W4vYW5kcm9pZC90ZXN0L21zYnVpbGR0ZXN0L0phdmFTb3VyY2VKYXJUZXN0LmNsYXNzUEsFBgAAAAADAAMA5wAAANYCAA
AAAA==";

		const string Resx = @"<?xml version=""1.0"" encoding=""utf-8""?>
<root>
	<resheader name=""resmimetype"">
		<value>text/microsoft-resx</value>
	</resheader>
	<resheader name=""version"">
		<value>2.0</value>
	</resheader>
	<resheader name=""reader"">
		<value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
	</resheader>
	<resheader name=""writer"">
		<value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
	</resheader>
	<!--contents-->
</root>";

		public static string ResxWithContents (string contents)
		{
			return Resx.Replace ("<!--contents-->", contents);
		}
	}
}
