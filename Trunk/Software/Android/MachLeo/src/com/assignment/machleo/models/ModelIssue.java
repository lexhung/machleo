package com.assignment.machleo.models;

import java.util.Calendar;

public class ModelIssue {
	private ModelUser author;
	private String content;
	private Calendar createdTime;
	private Calendar modifiedTime;
	
	public ModelIssue(ModelUser author, String content, Calendar createdTime)
	{
		this.author = author;
		this.content = content;
		this.createdTime = createdTime;
		this.modifiedTime = createdTime;
	}
	
	public ModelUser getAuthor()
	{
		return this.author;
	}
	
	public String getContent()
	{
		return this.content;
	}
	
	public void updateContent(String newContent)
	{
		this.content = newContent;		
	}
	
	public Calendar getCreatedTime()
	{
		return (Calendar)this.createdTime.clone();
	}
	
	public Calendar getModifiedTime()
	{
		return (Calendar)this.modifiedTime.clone();
	}
	
	public void updateModifiedTime(Calendar newModifiedTime)
	{
		this.modifiedTime = (Calendar)newModifiedTime.clone();
	}
}
