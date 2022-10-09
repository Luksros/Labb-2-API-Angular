import {HttpClient} from "@angular/common/http";
import {Department} from '../Models/Department.Model';
import {Injectable} from '@angular/core';
import { Observable } from "rxjs";

@Injectable({
    providedIn : 'root'
})

export class DepartmentService{
    baseUrl='https://localhost:7182/api/department'
    constructor(private http:HttpClient){ }

    getAllDepartments() : Observable<Department[]>{
        return this.http.get<Department[]>(this.baseUrl);
    }

    getDepartmentById(id:string) : Observable<Department>{
        return this.http.get<Department>(this.baseUrl + '/' + id)
    }

    addDepartment(department:Department) : Observable<Department>{
        return this.http.post<Department>(this.baseUrl, department);
    }

    deleteDepartment(id:string) : Observable<Department>{
        return this.http.delete<Department>(this.baseUrl + '/' + id);
    }

    updateDepartment(department:Department) : Observable<Department>{
        return this.http.put<Department>(this.baseUrl + '/' + department.id, department);
    }
}