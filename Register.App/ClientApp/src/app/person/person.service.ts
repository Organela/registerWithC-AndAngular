import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Person } from './person.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})
export class PersonService {

    //const personsUrl = 'api/persons';

    constructor(private readonly http: HttpClient) {

    }

    getAll(): Observable<Person[]> {
        return this.http.get<Person[]>('api/persons');
    }

    getById(id: number): Observable<Person> {
        return this.http.get<Person>('api/persons/${id}');
    }

    save(person: Person): Observable<Person> {
        if (person.id) {
            return this.updatePerson(person);
        }

        return this.createPerson(person);
    }

    updatePerson(person: Person): Observable<Person> {
        return this.http.put<Person>('api/persons/${person.id}', person);
    }

    createPerson(person: Person): Observable<Person> {
        return this.http.post<Person>('api/persons', person);
    }

    getLastId(): number {
        return 1;
    }

    deletePerson(person: Person): Observable<Person> {
          return this.http.delete<Person>('api/persons/${person.id}');
    }
}
