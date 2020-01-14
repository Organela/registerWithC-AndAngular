import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Person } from './person.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})
export class PersonService {
    private persons: Person[] = [
        {
            id: 2,
            name: 'Naruto',
            telephone: '799',
            email: 'naruto@gmail.com',
            state: 'RJ',
            city: 'Niterói'
        },
        {
            id: 9,
            name: 'André',
            telephone: '699',
            email: 'andre@gmail.com',
            state: 'RJ',
            city: 'Niterói'
        },
        {
            id: 12,
            name: 'Bruna',
            telephone: '299',
            email: 'bruna@gmail.com',
            state: 'RJ',
            city: 'Niterói'
        }
    ];

    constructor(private readonly http: HttpClient) {

    }

    getAll(): Observable<Person[]> {
        return this.http.get<Person[]>('api/persons');
    }

    getById(id: number): Observable<Person> {
        return of(this.persons.find(p => p.id === id));
    }

    save(person: Person): Observable<Person> {
        if (person.id) {
            return this.updatePerson(person);
        }

        return this.createPerson(person);
    }

    updatePerson(person: Person): Observable<Person> {
        let index = 0;

        this.persons.forEach(p => {
            if (p.id === person.id) {
                this.persons[index] = person;
                return;
            }
            index++;
        });

        return of({});
    }

    createPerson(person: Person): Observable<Person> {
        /*
        person.id = this.getLastId() + 1;
        this.persons.push(person);
        */
       return this.http.post<Person>('api/persons', person);
    }

    getLastId(): number {
        let max = 0;
        this.persons.forEach(p => {
            if (max < p.id) {
                max = p.id;
            }
        });
        return max;
    }

    deletePerson(person: Person) {
        if (this.persons.find(p => p.id === person.id)) {
            console.warn('deletePerson' + person.id);
            console.warn(this.persons.indexOf(person));
            this.persons.splice(this.persons.indexOf(person), 1);
        }
        return this.persons;
    }
}
