package com.assignment.machleo;

import com.assignment.machleo.controllers.DBAdapter;
import com.assignment.machleo.models.ModelIssue;
import com.assignment.machleo.models.ModelUser;

import android.app.Activity;
import android.os.Bundle;
import android.view.*;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

public class PostAct extends Activity implements View.OnClickListener {
	ImageView img_Picture;
	EditText txt_Content;
	Button btn_Save;
	Button btn_Cancel;
	
	ModelUser user;
	ModelIssue issue;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.post);
		
		img_Picture = (ImageView)findViewById(R.id.img_Picture_post);
		txt_Content = (EditText)findViewById(R.id.txt_content_post);
		
		btn_Save = (Button)findViewById(R.id.btn_Save_post);
		btn_Cancel = (Button)findViewById(R.id.btn_Cancel_post);
		
		img_Picture.setOnClickListener(this);
		btn_Save.setOnClickListener(this);
		btn_Cancel.setOnClickListener(this);
	}
	
	@Override
	public void onClick(View v) {
		switch(v.getId())
		{
		case R.id.img_Picture_post:
			// TODO: capture a picture
			break;
		case R.id.btn_Save_post:
			DBAdapter dbAdapter = new DBAdapter(user, issue);
			dbAdapter.saveIssue();
			break;
		case R.id.btn_Cancel_post:
			this.finish();
			break;
		}
	}
	
}
