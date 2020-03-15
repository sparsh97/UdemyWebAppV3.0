import { Component, OnInit } from '@angular/core';
import {ServicesService} from '../../services.service';
import {Router} from '@angular/router';
import { Courses } from 'src/app/models/Courses.model';
import { Observable,of } from 'rxjs';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-web-dev-list',
  templateUrl: './web-dev-list.component.html',
  styleUrls: ['./web-dev-list.component.css']
})
export class WebDevListComponent implements OnInit {

  course:Courses[]=[];

  public courses$: Observable<Courses[]>;

  displayedColums=['CategoryName','Description'];
  displayCourses=['CourseName', 'CourseDescription'];
  constructor(private service: ServicesService, private router:Router,public client: HttpClient) { }

  public ngOnInit() {
      this.service.fetchCourses().subscribe((course:Courses[])=>{
      this.course=course;
      console.log(this.course);
    
    })
}
}
