import { Component } from '@angular/core';
import { Employee } from './Models/Employee.Model'
import { EmployeeService } from './Services/Employee.Service'
import { Department } from './Models/Department.Model'
import { DepartmentService } from './Services/Departments.Service'
import { Gender } from './Models/Gender.Model'
import { GenderService } from './Services/Gender.Service'


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Labb2ApiAngular';

  employees: Employee[] = [];
  employee: Employee ={
    id: '',
    firstName: '',
    lastName: '',
    genderID: '',
    gender:  null,
    title:'',
    departmentID: '',
    department: null,
    address: '',
    salary: ''
  }

  departments: Department[] = [];
  department: Department ={
    id: '',
    departmentName: ''
  }

  genders: Gender[] = [];
  gender: Gender ={
    id: '',
    genderName: ''
  }

  constructor(private employeeService : EmployeeService, private departmentService: DepartmentService, private genderService : GenderService){

  }

  ngOnInit():void{
    this.getAllEmployees();
    this.getAllDepartments();
    this.getAllGenders();
  }

  getAllEmployees(){
    console.log('Get all')
    this.employeeService.getAllEmployees()
    .subscribe(
      response => {this.employees = response;})
  }

  empOnSubmit(){
    console.log(this.employee)
    if(this.employee.id == ''){
      this.employeeService.addEmployee(this.employee).subscribe(
        response => {
          this.getAllEmployees();
        }
      )
    }
    else{
      this.updateEmployee(this.employee);
    }
    this.employee = {
      id: '',
      firstName: '',
      lastName: '',
      address: '',
      salary: '',
      genderID: '',
      gender: null,
      title: '',
      departmentID: '',
      department: null     
    }
  }

  updateEmployee(employee:Employee){
    this.employeeService.updateEmployee(employee).subscribe(
      response => {
        this.getAllEmployees();
      }
    )
  }

  populateForm(employee:Employee){
    this.employee = employee
  }

  empOnDelete(id:string){
    this.employeeService.deleteEmployee(id).subscribe( response => {this.getAllEmployees();})
  }

  getAllDepartments(){
    this.departmentService.getAllDepartments()
    .subscribe(
      response => {this.departments = response;})
  }

  depOnSubmit(){
    if(this.department.id == ''){
      this.departmentService.addDepartment(this.department).subscribe(
        response => {
          this.getAllDepartments();
          this.department = {
            id: '',
            departmentName: ''
          }
        }
      )
    }
    else{
      this.updateDepartment(this.department);
    }
  }

  updateDepartment(department:Department){
    this.departmentService.updateDepartment(department).subscribe(
      response => {
        this.getAllDepartments();
      }
    )
  }

  depOnDelete(id:string){
    this.departmentService.deleteDepartment(id).subscribe( response => {this.getAllDepartments();})
  }

  getAllGenders(){
    this.genderService.getAllGenders().subscribe(response => {this.genders = response;})
  }
}
