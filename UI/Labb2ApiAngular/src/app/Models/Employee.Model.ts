import {Gender} from './Gender.Model'
import {Department} from './Department.Model'

export interface Employee{
    id:string,
    firstName:string,
    lastName:string,
    address:string,
    salary:string,
    genderID:string,
    gender:Gender|null,
    title:string,
    departmentID:string,
    department:Department|null
}