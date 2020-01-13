import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';

import { PersonService } from '../person.service';
import { Person } from '../person.model';

@Component({
  selector: 'app-person-edit',
  templateUrl: './person-edit.component.html',
  styleUrls: ['./person-edit.component.scss']
})
export class PersonEditComponent {
  personForm: FormGroup;

  constructor(private personService: PersonService,
              private router: Router,
              private route: ActivatedRoute,
              private formBuilder: FormBuilder) {
    this.route.paramMap.subscribe(params => {
      const id = +params.get('id');

      this.personForm = this.formBuilder.group({
        id,
        name: [ null, [Validators.required, Validators.minLength(4)] ],
        telephone: null,
        email: null,
        state: null,
        city: null
      });

      personService.getById(id).subscribe(person => {
        if (person !== undefined && person !== null) {
          this.personForm.patchValue(person);
        }
      });
    });
  }

  save() {
    this.personService.save(this.personForm.value);
    this.router.navigate(['person', 'list']);
  }
}
