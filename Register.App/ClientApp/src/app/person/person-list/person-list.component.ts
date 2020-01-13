import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';


import { PersonService } from '../person.service';
import { Person } from '../person.model';

@Component({
  selector: 'app-person-list',
  templateUrl: './person-list.component.html',
  styleUrls: ['./person-list.component.scss']
})
export class PersonListComponent implements OnInit {

  persons: any;
  displayedColumns: string[] = ['name', 'telephone', 'email', 'state', 'city', 'action'];

  applyFilter(filterValue: string) {
    this.persons.filter = filterValue.trim().toLowerCase();
  }
  constructor(readonly personService: PersonService) {


    personService.getAll().subscribe(persons => {
      this.persons = new MatTableDataSource(persons);
    });


  }

  ngOnInit() {
  }

  onDelete(person: Person) {
    this.persons = new MatTableDataSource(this.personService.deletePerson(person));
  }

}
