package com.assignment.machleo.controllers;

import java.util.Vector;

import com.assignment.machleo.models.ModelIssue;
import com.assignment.machleo.models.ModelUser;

public class DBAdapter {
	ModelUser user;
	ModelIssue issue;
	
	public DBAdapter(ModelUser user)
	{
		this.user = user;
	}
	
	public DBAdapter(ModelUser user, ModelIssue issue)
	{
		this.user = user;
		this.issue = issue;
	}
	
	public static void InitDatabase()
	{
		//TODO: copy the database to phone if it doesn't exist
	}
	
	public Vector<ModelIssue> getAllIssues()
	{
		//TODO: get all issue of this.user
		return null;
	}
	
	public ModelIssue getIssueById(int id)
	{
		//TODO: get the issue of this.user by id
		return null;
	}
	
	public boolean deleteIssue()
	{
		//TODO: delete this.issue from the database
		return false;
	}
	
	public boolean saveIssue()
	{
		//TODO: save this.issue to the database
		return false;
	}
}
