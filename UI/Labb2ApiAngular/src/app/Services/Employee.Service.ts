import {HttpClient} from "@angular/common/http";
import {Employee} from '../Models/Employee.Model';
import {Injectable} from '@angular/core';
import { Observable } from "rxjs";

@Injectable({
    providedIn : 'root'
})

export class EmployeeService{
    baseUrl='https://localhost:7182/api/employees'
    constructor(private http:HttpClient){ }

    getAllEmployees() : Observable<Employee[]>{
        return this.http.get<Employee[]>(this.baseUrl);
    }

    getEmployeeById(id:string) : Observable<Employee>{
        return this.http.get<Employee>(this.baseUrl + '/' + id);
    }

    addEmployee(employee:Employee) : Observable<Employee>{
        employee.id = '0';
        return this.http.post<Employee>(this.baseUrl, employee);
    }

    deleteEmployee(id:string) : Observable<Employee>{
        return this.http.delete<Employee>(this.baseUrl + '/' + id);
    }

    updateEmployee(employee:Employee) : Observable<Employee>{
        return this.http.put<Employee>(this.baseUrl + '/' + employee.id, employee)
    }
}