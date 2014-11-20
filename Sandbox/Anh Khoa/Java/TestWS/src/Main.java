import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.Reader;
import java.net.URL;
import java.nio.charset.Charset;

import org.json.JSONException;
import org.json.JSONObject;

import com.google.gson.Gson;

public class Main {
	public class Person
	{
		private int Age;
		private String Name;
		
		public int getAge() {
			return Age;
		}
		public void setAge(int age) {
			Age = age;
		}
		public String getName() {
			return Name;
		}
		public void setName(String name) {
			Name = name;
		}			
	}
	
	public static void main(String[] args) {		
	    try {
	    	Gson g = new Gson();
			JSONObject json = readJsonFromUrl("http://localhost:1120/values/GetPerson");
			Person p = g.fromJson(json.toString(), Person.class);
			
			if (p != null)
			{
				System.out.print(p.getAge() + " " + p.getName());	
			}			
		} catch (IOException e) {
			e.printStackTrace();
		} catch (JSONException e) {
			e.printStackTrace();
		}
	}

	private static String readAll(Reader rd) throws IOException {
	    StringBuilder sb = new StringBuilder();
	    int cp;
	    while ((cp = rd.read()) != -1) {
	      sb.append((char) cp);
	    }
	    return sb.toString();
	  }
	
	private static JSONObject readJsonFromUrl(String url) throws IOException, JSONException {
	    InputStream is = new URL(url).openStream();
	    try {
	      BufferedReader rd = new BufferedReader(new InputStreamReader(is, Charset.forName("UTF-8")));
	      String jsonText = readAll(rd);
	      JSONObject json = new JSONObject(jsonText);
	      return json;
	    } finally {
	      is.close();
	    }
	  }
}
