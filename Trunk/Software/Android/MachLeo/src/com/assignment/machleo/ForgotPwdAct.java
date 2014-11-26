package com.assignment.machleo;

import android.app.Activity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;

import android.view.*;

public class ForgotPwdAct extends Activity implements View.OnClickListener {
	EditText txt_email;
	Button btn_submit;
	@Override
	protected void onCreate(Bundle savedInstanceState)
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.forgotpass);
		
		txt_email = (EditText)findViewById(R.id.txt_email_forgotpwd);
		btn_submit = (Button)findViewById(R.id.btn_submit_forgotpwd);
		
		btn_submit.setOnClickListener(this);
	}
	@Override
	public void onClick(View v) {
		if(v.getId()==R.id.btn_submit_forgotpwd)
		{
			this.finish();
		}
	}
}
