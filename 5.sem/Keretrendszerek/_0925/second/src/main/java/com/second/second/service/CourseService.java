package com.second.second.service;

import java.util.*;

import org.springframework.stereotype.Service;

import com.second.second.model.Course;

@Service
public class CourseService {

	private static List<Course> courses = new ArrayList<Course>();
	
	static {
		Course firstCourse = new Course("first", "first name", "first discription");
		Course secondCourse = new Course("secon", "secon name", "secon discription");
		Course thirdCourse = new Course("third", "third name", "third discription");
		
		courses.add(firstCourse);
		courses.add(secondCourse);
		courses.add(thirdCourse);
		
	}
	
	public List<Course> getAllCourse(){
		return courses;
	}
	
	
	public Course getCourse(String id) {
		for(Course course : courses) {
			if(course.getId().equals(id)) {
				return course;
			}
		}
		return null;
	}
	
	
	public Course createCourse(Course c) {
		//courses.add(c); <- TILOS!!!!
		/*Course course = new Course();
		course.setId(c.getId());
		course.setDescription(c.getDescription());
		course.setName(c.getName());*/
		
		Course course = new Course(c.getId(), c.getName(), c.getDescription());
		courses.add(course);
		return course;
	}
	
	
	
	
}
