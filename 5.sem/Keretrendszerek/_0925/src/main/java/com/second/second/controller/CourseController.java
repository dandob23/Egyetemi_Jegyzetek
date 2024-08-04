package com.second.second.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.second.second.model.Course;
import com.second.second.service.CourseService;

@RestController
public class CourseController {

	@Autowired
	CourseService courseService;
	
	@GetMapping("/courses")
	public ResponseEntity<Object> getAllCourse(){
		List<Course> courses = courseService.getAllCourse();
		if(courses.isEmpty()) {
			return ResponseEntity.status(HttpStatus.NO_CONTENT).body("Nem talált egyet sem");
		}
		
		return ResponseEntity.status(HttpStatus.OK).body(courses);
	}
	
	@GetMapping("/course/{courseId}")
	public ResponseEntity<Course> getCourse(@PathVariable String courseId){
		Course c = courseService.getCourse(courseId);
		if(c == null) {
			return ResponseEntity.status(HttpStatus.NO_CONTENT).body(null);
		}
		
		return ResponseEntity.status(HttpStatus.OK).body(c);
	}
	
	
	@PostMapping("/create_course")
	public ResponseEntity<Course> createCourse(@RequestBody Course course){
		if(courseService.getCourse(course.getId()) != null) {
			return ResponseEntity.status(HttpStatus.CONFLICT).body(null);
		}
		Course c = courseService.createCourse(course);
		return ResponseEntity.status(HttpStatus.OK).body(c);
	}
	
	
	@PostMapping("/update_course/{course_id}")
	public ResponseEntity<Course> updateCourse(@RequestBody Course course, @PathVariable String course_id){
		
	}
	
	
	
	
	
}
