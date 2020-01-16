import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';


import { PersonService } from '../person.service';
import { Person } from '../person.model';
import { findLast } from '@angular/compiler/src/directive_resolver';

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
    this.load();
  }

  ngOnInit() {
  }

  load() {
    this.personService.getAll().subscribe(persons => {
      this.persons = new MatTableDataSource(persons);// This persons agora tem os valores das persons do Banco
    });

  }

  onDelete(person: Person) {
    this.personService.deletePerson(person).subscribe(() => {
      this.load();// Pensar em uma forma de deletar manualmente o person no client side - Método find?
    });
  }
}
