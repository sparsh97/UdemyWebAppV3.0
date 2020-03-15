import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable, throwError,of } from 'rxjs';
import { Courses } from './models/Courses.model';
import { retry, catchError } from 'rxjs/operators';
import {environment} from 'src/environments/environment';
import {map} from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class ServicesService {
  uri='https://localhost:44353/api';
  constructor( private http: HttpClient) { }

  public fetchCourses(){
    return this.http.get<Courses[]>(`${this.uri}/Courses`);
  }
}
