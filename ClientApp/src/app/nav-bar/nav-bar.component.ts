import { Component, OnInit } from '@angular/core';
import { ServicesService } from '../services.service';
import { Courses } from '../models/Courses.model';
 
@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {
 
  navbarOpen = false;
 
  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
  course:Courses[]=[];

  // public courses$: Observable<Courses[]>;
 
   //displayedColums=['CategoryName','Description'];
   //displayCourses=['CourseName', 'CourseDescription'];
   constructor(private service: ServicesService) { }
 
   public ngOnInit() {
       this.service.fetchCourses().subscribe((course:Courses[])=>{
       this.course=course;
       console.log(this.course);
     
     })
 }
}