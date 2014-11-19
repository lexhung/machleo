package com.assignment.machleo.models;

public class ModelUser {
	private String username;
	private String password;
	
	public ModelUser(String uname, String pwd)
	{
		this.username = uname;
		this.password = pwd;
	}
	
	public String getUsername()
	{
		return this.username;
	}
	
	public String getPassword()
	{
		return this.password;
	}
}
