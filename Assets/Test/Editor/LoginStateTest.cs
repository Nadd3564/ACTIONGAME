﻿using NUnit.Framework;
using Cradle.DesignPattern;
using NSubstitute;


namespace Cradle.Test
{
	[TestFixture]
	[Category ("LogInState Test")]
	public class LogInStateTest
	{
		private LogInState logInState;
		private SceneManagerController manager;
		
		[SetUp] public void Init()
		{
			logInState = Substitute.For<LogInState>();
		}
		
		[TearDown] public void Cleanup()
		{
			
		}

		//データ型テスト（オブジェクト）
		[Test]
		[Category ("id Type Test")]
		public void IdTypeTest() 
		{
			Assert.That (logInState.GetID(), Is.TypeOf(typeof(string)));		
		}

		[Test]
		[Category ("passwordToEdit Type Test")]
		public void passwordToEditTypeTest() 
		{
			Assert.That (logInState.GetPass(), Is.TypeOf(typeof(string)));		
		}

		[Test]
		[Category ("success Type Test")]
		public void successTypeTest() 
		{
			Assert.That (logInState.GetSuccess(), Is.TypeOf(typeof(string)));		
		}

		//正常値テスト（オブジェクト）
		[Test]
		[Category ("id Test")]
		public void IdTest () 
		{
			Assert.IsEmpty (logInState.GetID());
		}
		
		[Test]
		[Category ("passwordToEdit Test")]
		public void PasswordToEditTest () 
		{
			Assert.IsEmpty (logInState.GetPass());
		}
		
		[Test]
		[Category ("success Test")]
		public void SuccessTest () 
		{
			string text = "AuthenticateProxy: Success Authenticated";
			StringAssert.Contains (text, logInState.GetSuccess());
		}

		[Test]
		[Category ("color Test")]
		public void ColorTest () 
		{
			string s = "GUIStyle ''";
			logInState.SetTextStyle ();
			StringAssert.Contains (s ,logInState.GetColor());
		}

		[Test]
		[Category ("buttonStyle Test")]
		public void buttonStyleTest () 
		{
			string s = "GUIStyle 'button'";
			logInState.SetButtonStyle ();
			StringAssert.Contains (s ,logInState.GetButtonStyle());
		}

	}
}

