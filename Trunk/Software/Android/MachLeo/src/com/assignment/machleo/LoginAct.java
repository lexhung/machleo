package com.assignment.machleo;

import com.assignment.machleo.controllers.ServiceTransfer;
import com.assignment.machleo.models.*;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.*;
import android.widget.*;

public class LoginAct extends Activity implements View.OnClickListener {
	EditText txt_username;
	EditText txt_password;
	Button btn_SignIn;
	Button btn_SignUp;
	Button btn_forgotpass;
	
	ModelUser user;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.login);
		
		txt_username = (EditText)findViewById(R.id.txt_username_login);
		txt_password = (EditText)findViewById(R.id.txt_password_login);
		
		btn_SignIn = (Button)findViewById(R.id.btn_SignIn_login);
		btn_SignUp = (Button)findViewById(R.id.btn_SignUp_login);
		btn_forgotpass = (Button)findViewById(R.id.btn_forgotpass_login);
		
		btn_SignIn.setOnClickListener(this);
		btn_SignUp.setOnClickListener(this);
		btn_forgotpass.setOnClickListener(this);
	}

	@Override
	public void onClick(View v) {
		Intent intent;
		switch(v.getId())
		{
		case R.id.btn_SignIn_login:
			user = new ModelUser(txt_username.getText().toString(), txt_password.getText().toString());
			if(ServiceTransfer.login(user))
			{
				intent = new Intent(this, PostAct.class);
				startActivity(intent);
			}
			break;
		case R.id.btn_SignUp_login:
			intent = new Intent(this, SignUpAct.class);
			startActivity(intent);
			break;
		case R.id.btn_forgotpass_login:
			intent = new Intent(this, ForgotPwdAct.class);
			startActivity(intent);
			break;
		}
	}
}
