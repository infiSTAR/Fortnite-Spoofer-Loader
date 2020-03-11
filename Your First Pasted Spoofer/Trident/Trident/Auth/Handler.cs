using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

namespace Auth
{
	// Token: 0x02000003 RID: 3
	internal class Handler
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002154 File Offset: 0x00000354
		public static void Initialize()
		{
			Handler.Authentication.OpenEncryption();
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Headers["User-Agent"] = "AuthGG";
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "start";
					nameValueCollection["57663"] = Settings.AID;
					nameValueCollection["eij7RbU1x0GpyeLO2lKeKEbTdvUI1RS4iix"] = Settings.Secret;
					byte[] bytes = webClient.UploadValues("https://api.auth.gg/v2/api.php", nameValueCollection);
					string @string = Encoding.Default.GetString(bytes);
					object arg = JsonConvert.DeserializeObject(@string);
					if (Handler.<>o__2.<>p__1 == null)
					{
						Handler.<>o__2.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target = Handler.<>o__2.<>p__1.Target;
					CallSite <>p__ = Handler.<>o__2.<>p__1;
					if (Handler.<>o__2.<>p__0 == null)
					{
						Handler.<>o__2.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "status", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Status = target(<>p__, Handler.<>o__2.<>p__0.Target(Handler.<>o__2.<>p__0, arg));
					if (Handler.<>o__2.<>p__3 == null)
					{
						Handler.<>o__2.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target2 = Handler.<>o__2.<>p__3.Target;
					CallSite <>p__2 = Handler.<>o__2.<>p__3;
					if (Handler.<>o__2.<>p__2 == null)
					{
						Handler.<>o__2.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "hash", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Hash = target2(<>p__2, Handler.<>o__2.<>p__2.Target(Handler.<>o__2.<>p__2, arg));
					if (Handler.<>o__2.<>p__5 == null)
					{
						Handler.<>o__2.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target3 = Handler.<>o__2.<>p__5.Target;
					CallSite <>p__3 = Handler.<>o__2.<>p__5;
					if (Handler.<>o__2.<>p__4 == null)
					{
						Handler.<>o__2.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "version", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Version = target3(<>p__3, Handler.<>o__2.<>p__4.Target(Handler.<>o__2.<>p__4, arg));
					if (Handler.<>o__2.<>p__7 == null)
					{
						Handler.<>o__2.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target4 = Handler.<>o__2.<>p__7.Target;
					CallSite <>p__4 = Handler.<>o__2.<>p__7;
					if (Handler.<>o__2.<>p__6 == null)
					{
						Handler.<>o__2.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "downloadlink", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.DownloadLink = target4(<>p__4, Handler.<>o__2.<>p__6.Target(Handler.<>o__2.<>p__6, arg));
					if (Handler.<>o__2.<>p__9 == null)
					{
						Handler.<>o__2.<>p__9 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target5 = Handler.<>o__2.<>p__9.Target;
					CallSite <>p__5 = Handler.<>o__2.<>p__9;
					if (Handler.<>o__2.<>p__8 == null)
					{
						Handler.<>o__2.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "freemode", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Freemode = target5(<>p__5, Handler.<>o__2.<>p__8.Target(Handler.<>o__2.<>p__8, arg));
					if (Handler.<>o__2.<>p__11 == null)
					{
						Handler.<>o__2.<>p__11 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target6 = Handler.<>o__2.<>p__11.Target;
					CallSite <>p__6 = Handler.<>o__2.<>p__11;
					if (Handler.<>o__2.<>p__10 == null)
					{
						Handler.<>o__2.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "login", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Login = target6(<>p__6, Handler.<>o__2.<>p__10.Target(Handler.<>o__2.<>p__10, arg));
					if (Handler.<>o__2.<>p__13 == null)
					{
						Handler.<>o__2.<>p__13 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target7 = Handler.<>o__2.<>p__13.Target;
					CallSite <>p__7 = Handler.<>o__2.<>p__13;
					if (Handler.<>o__2.<>p__12 == null)
					{
						Handler.<>o__2.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "register", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Register = target7(<>p__7, Handler.<>o__2.<>p__12.Target(Handler.<>o__2.<>p__12, arg));
					if (Handler.<>o__2.<>p__15 == null)
					{
						Handler.<>o__2.<>p__15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target8 = Handler.<>o__2.<>p__15.Target;
					CallSite <>p__8 = Handler.<>o__2.<>p__15;
					if (Handler.<>o__2.<>p__14 == null)
					{
						Handler.<>o__2.<>p__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "developermode", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.DeveloperMode = target8(<>p__8, Handler.<>o__2.<>p__14.Target(Handler.<>o__2.<>p__14, arg));
					if (Handler.<>o__2.<>p__17 == null)
					{
						Handler.<>o__2.<>p__17 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target9 = Handler.<>o__2.<>p__17.Target;
					CallSite <>p__9 = Handler.<>o__2.<>p__17;
					if (Handler.<>o__2.<>p__16 == null)
					{
						Handler.<>o__2.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "applicationname", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					ProgramInfo.Application = target9(<>p__9, Handler.<>o__2.<>p__16.Target(Handler.<>o__2.<>p__16, arg));
					bool flag = ProgramInfo.Status == "Enabled";
					if (flag)
					{
						MessageBox.Show("This application is disabled!", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Process.GetCurrentProcess().Kill();
					}
					bool flag2 = ProgramInfo.DeveloperMode == "Enabled";
					if (flag2)
					{
						bool flag3 = ProgramInfo.Version != Settings.Version;
						if (flag3)
						{
							MessageBox.Show("Update [" + ProgramInfo.Version + "] is available!", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							Process.Start(ProgramInfo.DownloadLink);
						}
						string b = Handler.CalculateMD5(Application.ExecutablePath);
						bool flag4 = ProgramInfo.Hash != b;
						if (flag4)
						{
							MessageBox.Show("Hashes do not match, file tampering possible!", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							Process.GetCurrentProcess().Kill();
						}
					}
				}
				catch
				{
					MessageBox.Show("Welcome TridentSpoofer!", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			Handler.Authentication.CloseEncryption();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002860 File Offset: 0x00000A60
		public static void Log(string username, string action)
		{
			Handler.Authentication.OpenEncryption();
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Headers["User-Agent"] = "AuthGG";
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "log";
					nameValueCollection["57663"] = Settings.AID;
					nameValueCollection["eij7RbU1x0GpyeLO2lKeKEbTdvUI1RS4iix"] = Settings.Secret;
					nameValueCollection["time"] = Settings.Time();
					nameValueCollection["username"] = username;
					nameValueCollection["pcuser"] = Environment.UserName;
					nameValueCollection["action"] = action;
					byte[] array = webClient.UploadValues("https://api.auth.gg/v2/api.php", nameValueCollection);
				}
				catch
				{
					MessageBox.Show("Something went wrong!", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			Handler.Authentication.CloseEncryption();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002960 File Offset: 0x00000B60
		public static bool Login(string username, string password)
		{
			bool flag = ProgramInfo.Login != "Enabled";
			if (flag)
			{
				MessageBox.Show("Login is not available at this time!", "TridentSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Handler.Authentication.OpenEncryption();
					webClient.Headers["User-Agent"] = "AuthGG";
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "login";
					nameValueCollection["username"] = username;
					nameValueCollection["password"] = password;
					nameValueCollection["hwid"] = Settings.HWID();
					nameValueCollection["aid"] = Settings.AID;
					nameValueCollection["secret"] = Settings.Secret;
					nameValueCollection["time"] = Settings.Time();
					byte[] bytes = webClient.UploadValues("https://api.auth.gg/v2/api.php", nameValueCollection);
					string @string = Encoding.Default.GetString(bytes);
					object arg = JsonConvert.DeserializeObject(@string);
					Handler.Authentication.CloseEncryption();
					if (Handler.<>o__4.<>p__1 == null)
					{
						Handler.<>o__4.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target = Handler.<>o__4.<>p__1.Target;
					CallSite <>p__ = Handler.<>o__4.<>p__1;
					if (Handler.<>o__4.<>p__0 == null)
					{
						Handler.<>o__4.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "result", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					string text = target(<>p__, Handler.<>o__4.<>p__0.Target(Handler.<>o__4.<>p__0, arg));
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							if (Handler.<>o__4.<>p__3 == null)
							{
								Handler.<>o__4.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target2 = Handler.<>o__4.<>p__3.Target;
							CallSite <>p__2 = Handler.<>o__4.<>p__3;
							if (Handler.<>o__4.<>p__2 == null)
							{
								Handler.<>o__4.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "id", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.ID = target2(<>p__2, Handler.<>o__4.<>p__2.Target(Handler.<>o__4.<>p__2, arg));
							if (Handler.<>o__4.<>p__5 == null)
							{
								Handler.<>o__4.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target3 = Handler.<>o__4.<>p__5.Target;
							CallSite <>p__3 = Handler.<>o__4.<>p__5;
							if (Handler.<>o__4.<>p__4 == null)
							{
								Handler.<>o__4.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "logged_in", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.Logged_In = bool.Parse(target3(<>p__3, Handler.<>o__4.<>p__4.Target(Handler.<>o__4.<>p__4, arg)));
							if (Handler.<>o__4.<>p__7 == null)
							{
								Handler.<>o__4.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target4 = Handler.<>o__4.<>p__7.Target;
							CallSite <>p__4 = Handler.<>o__4.<>p__7;
							if (Handler.<>o__4.<>p__6 == null)
							{
								Handler.<>o__4.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "username", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.Username = target4(<>p__4, Handler.<>o__4.<>p__6.Target(Handler.<>o__4.<>p__6, arg));
							if (Handler.<>o__4.<>p__9 == null)
							{
								Handler.<>o__4.<>p__9 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target5 = Handler.<>o__4.<>p__9.Target;
							CallSite <>p__5 = Handler.<>o__4.<>p__9;
							if (Handler.<>o__4.<>p__8 == null)
							{
								Handler.<>o__4.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "email", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.Email = target5(<>p__5, Handler.<>o__4.<>p__8.Target(Handler.<>o__4.<>p__8, arg));
							if (Handler.<>o__4.<>p__11 == null)
							{
								Handler.<>o__4.<>p__11 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target6 = Handler.<>o__4.<>p__11.Target;
							CallSite <>p__6 = Handler.<>o__4.<>p__11;
							if (Handler.<>o__4.<>p__10 == null)
							{
								Handler.<>o__4.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "hwid", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.HWID = target6(<>p__6, Handler.<>o__4.<>p__10.Target(Handler.<>o__4.<>p__10, arg));
							if (Handler.<>o__4.<>p__13 == null)
							{
								Handler.<>o__4.<>p__13 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target7 = Handler.<>o__4.<>p__13.Target;
							CallSite <>p__7 = Handler.<>o__4.<>p__13;
							if (Handler.<>o__4.<>p__12 == null)
							{
								Handler.<>o__4.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "variable", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.Variable = target7(<>p__7, Handler.<>o__4.<>p__12.Target(Handler.<>o__4.<>p__12, arg));
							if (Handler.<>o__4.<>p__15 == null)
							{
								Handler.<>o__4.<>p__15 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target8 = Handler.<>o__4.<>p__15.Target;
							CallSite <>p__8 = Handler.<>o__4.<>p__15;
							if (Handler.<>o__4.<>p__14 == null)
							{
								Handler.<>o__4.<>p__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "expiry", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.Expiry = target8(<>p__8, Handler.<>o__4.<>p__14.Target(Handler.<>o__4.<>p__14, arg));
							if (Handler.<>o__4.<>p__17 == null)
							{
								Handler.<>o__4.<>p__17 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target9 = Handler.<>o__4.<>p__17.Target;
							CallSite <>p__9 = Handler.<>o__4.<>p__17;
							if (Handler.<>o__4.<>p__16 == null)
							{
								Handler.<>o__4.<>p__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "rank", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.Rank = target9(<>p__9, Handler.<>o__4.<>p__16.Target(Handler.<>o__4.<>p__16, arg));
							if (Handler.<>o__4.<>p__19 == null)
							{
								Handler.<>o__4.<>p__19 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
							}
							Func<CallSite, object, string> target10 = Handler.<>o__4.<>p__19.Target;
							CallSite <>p__10 = Handler.<>o__4.<>p__19;
							if (Handler.<>o__4.<>p__18 == null)
							{
								Handler.<>o__4.<>p__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "ip", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							UserInfo.IP = target10(<>p__10, Handler.<>o__4.<>p__18.Target(Handler.<>o__4.<>p__18, arg));
							if (Handler.<>o__4.<>p__23 == null)
							{
								Handler.<>o__4.<>p__23 = CallSite<Func<CallSite, object, Dictionary<string, object>>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Dictionary<string, object>), typeof(Handler)));
							}
							Func<CallSite, object, Dictionary<string, object>> target11 = Handler.<>o__4.<>p__23.Target;
							CallSite <>p__11 = Handler.<>o__4.<>p__23;
							if (Handler.<>o__4.<>p__22 == null)
							{
								Handler.<>o__4.<>p__22 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "DeserializeObject", new Type[]
								{
									typeof(Dictionary<string, object>)
								}, typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, Type, object, object> target12 = Handler.<>o__4.<>p__22.Target;
							CallSite <>p__12 = Handler.<>o__4.<>p__22;
							Type typeFromHandle = typeof(JsonConvert);
							if (Handler.<>o__4.<>p__21 == null)
							{
								Handler.<>o__4.<>p__21 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, object> target13 = Handler.<>o__4.<>p__21.Target;
							CallSite <>p__13 = Handler.<>o__4.<>p__21;
							if (Handler.<>o__4.<>p__20 == null)
							{
								Handler.<>o__4.<>p__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "vars", typeof(Handler), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Handler.Vars = target11(<>p__11, target12(<>p__12, typeFromHandle, target13(<>p__13, Handler.<>o__4.<>p__20.Target(Handler.<>o__4.<>p__20, arg))));
							MessageBox.Show("Welcome back, " + username + "!", ProgramInfo.Application ?? "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return true;
						}
						if (text2 == "invalid_details")
						{
							return false;
						}
						if (text2 == "invalid_hwid")
						{
							MessageBox.Show("Invalid HWID, please do not attempt to share accounts! If you have reset your windows than please contact Imperious#0001 to reset your HWID", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (text2 == "hwid_updated")
						{
							MessageBox.Show("Your HWID has been updated, relogin!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return false;
						}
						if (text2 == "time_expired")
						{
							MessageBox.Show("Your subscription has expired!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (text2 == "net_error")
						{
							MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
				catch
				{
					MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00003318 File Offset: 0x00001518
		public static bool Register(string username, string password, string email, string token)
		{
			bool flag = ProgramInfo.Register != "Enabled";
			if (flag)
			{
				MessageBox.Show("Register is not available at this time!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.GetCurrentProcess().Kill();
			}
			bool result;
			try
			{
				Handler.Authentication.OpenEncryption();
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers["User-Agent"] = "AuthGG";
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "register";
					nameValueCollection["username"] = username;
					nameValueCollection["password"] = password;
					nameValueCollection["email"] = email;
					nameValueCollection["token"] = token;
					nameValueCollection["hwid"] = Settings.HWID();
					nameValueCollection["aid"] = Settings.AID;
					nameValueCollection["secret"] = Settings.Secret;
					byte[] bytes = webClient.UploadValues("https://api.auth.gg/v2/api.php", nameValueCollection);
					string @string = Encoding.Default.GetString(bytes);
					object arg = JsonConvert.DeserializeObject(@string);
					Handler.Authentication.CloseEncryption();
					if (Handler.<>o__5.<>p__1 == null)
					{
						Handler.<>o__5.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target = Handler.<>o__5.<>p__1.Target;
					CallSite <>p__ = Handler.<>o__5.<>p__1;
					if (Handler.<>o__5.<>p__0 == null)
					{
						Handler.<>o__5.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "result", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					string text = target(<>p__, Handler.<>o__5.<>p__0.Target(Handler.<>o__5.<>p__0, arg));
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							MessageBox.Show(username + ", you have successfully registered!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							return true;
						}
						if (text2 == "invalid_token")
						{
							MessageBox.Show("Invalid License!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (text2 == "email_used")
						{
							MessageBox.Show("Email is invalid or in use!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (text2 == "invalid_username")
						{
							MessageBox.Show("Invalid Username!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					result = false;
				}
			}
			catch
			{
				MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000035D8 File Offset: 0x000017D8
		public static bool Login_Register_Redeem_With_Key(string key)
		{
			bool flag = Handler.Login(key, key);
			bool flag2 = flag;
			bool result;
			if (flag2)
			{
				result = true;
			}
			else
			{
				bool flag3 = Handler.Register(key, key, key, key);
				bool flag4 = flag3;
				if (flag4)
				{
					MessageBox.Show("Success, please restart application!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Process.GetCurrentProcess().Kill();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003634 File Offset: 0x00001834
		public static bool RedeemToken(string username, string password, string token)
		{
			try
			{
				Handler.Authentication.OpenEncryption();
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers["User-Agent"] = "AuthGG";
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["type"] = "redeem";
					nameValueCollection["username"] = username;
					nameValueCollection["password"] = password;
					nameValueCollection["token"] = token;
					nameValueCollection["aid"] = Settings.AID;
					nameValueCollection["secret"] = Settings.Secret;
					byte[] bytes = webClient.UploadValues("https://api.auth.gg/v2/api.php", nameValueCollection);
					string @string = Encoding.Default.GetString(bytes);
					object arg = JsonConvert.DeserializeObject(@string);
					Handler.Authentication.CloseEncryption();
					if (Handler.<>o__7.<>p__1 == null)
					{
						Handler.<>o__7.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Handler)));
					}
					Func<CallSite, object, string> target = Handler.<>o__7.<>p__1.Target;
					CallSite <>p__ = Handler.<>o__7.<>p__1;
					if (Handler.<>o__7.<>p__0 == null)
					{
						Handler.<>o__7.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "result", typeof(Handler), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					string text = target(<>p__, Handler.<>o__7.<>p__0.Target(Handler.<>o__7.<>p__0, arg));
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							return true;
						}
						if (text2 == "invalid_token")
						{
							MessageBox.Show("Invalid License!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (text2 == "invalid_details")
						{
							MessageBox.Show("Invalid Credentials!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (text2 == "net_error")
						{
							MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
					}
					return false;
				}
			}
			catch
			{
				MessageBox.Show("Something went wrong!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			return false;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003874 File Offset: 0x00001A74
		private static string CalculateMD5(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000038F4 File Offset: 0x00001AF4
		public static string GetVariable(string variable)
		{
			string result;
			try
			{
				bool logged_In = UserInfo.Logged_In;
				if (logged_In)
				{
					result = Handler.Vars[variable].ToString();
				}
				else
				{
					bool flag = ProgramInfo.Freemode == "Enabled";
					if (flag)
					{
						result = Handler.Vars[variable].ToString();
					}
					else
					{
						MessageBox.Show("Attempting to get variable without being logged in!", "AppleSpoofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						result = "[ERROR] : You are not logged in!";
					}
				}
			}
			catch
			{
				result = "[ERROR] : Variable does not exist!";
			}
			return result;
		}

		// Token: 0x04000002 RID: 2
		private const string V = "57663";

		// Token: 0x04000003 RID: 3
		private static Dictionary<string, object> Vars = new Dictionary<string, object>();

		// Token: 0x0200000F RID: 15
		internal class Authentication
		{
			// Token: 0x06000062 RID: 98 RVA: 0x0000AD66 File Offset: 0x00008F66
			public static void OpenEncryption()
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Handler.Authentication.PinPublicKey));
			}

			// Token: 0x06000063 RID: 99 RVA: 0x0000AD8A File Offset: 0x00008F8A
			public static void CloseEncryption()
			{
				ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
			}

			// Token: 0x06000064 RID: 100 RVA: 0x0000ADB4 File Offset: 0x00008FB4
			private static bool PinPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
			{
				return certificate != null && certificate.GetPublicKeyString() == "041B6566A801CC518B5AC35FE91FCF4BDD9E94F3AE8156DF327083B7DA8A62D5CE2A4C25245F1567A0AC51EF12C549E8D62CC27DB1398DE17F62015ADF00207D5D";
			}

			// Token: 0x04000025 RID: 37
			private const string _key = "041B6566A801CC518B5AC35FE91FCF4BDD9E94F3AE8156DF327083B7DA8A62D5CE2A4C25245F1567A0AC51EF12C549E8D62CC27DB1398DE17F62015ADF00207D5D";
		}
	}
}
