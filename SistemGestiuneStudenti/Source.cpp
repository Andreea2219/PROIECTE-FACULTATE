#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <sstream>

using namespace std;

class Persoana {
protected:
	string nume;
	string prenume;
	string email;

public:
	Persoana(string nume,string prenume, string email) {
		this->nume = nume;
		this->prenume = prenume;
		this->email = email;
	}
	Persoana() {
		this->nume = "";
		this->prenume = "";
		this->email = "";
	}
	string getNume() {
		return this->nume;
	}

	void setNume(string nume) {
		this->nume = nume;
	}

	string getPrenume() {
		return this->prenume;
	}

	void setPrenume(string prenume) {
		this->prenume = prenume;
	}

	string getEmail() {
		return this->email;
	}

	void setEmail(string email) {
		this->email = email;
	}

	void Afisare() {
		cout << "Nume: " << this->nume << " | Email: " << this->email << endl;
	}
};

class Profesor : public Persoana {
private:
	string departament;
public:
	Profesor(string nume, string prenume, string email, string departament) : Persoana(nume, prenume, email) {
		this->departament = departament;
	}
	
	string getDepartament() {
		return this->departament;
	}

	void setDepartament(string departament) {
		this->departament = departament;
	}

	void AfisareProfesor() {
		cout << "Nume: " << this->nume << " | Prenume: " << this->prenume << " | Email: " << this->email << " | Departament: " << this->departament << endl;
	}
};

class Curs {
private:
	int cod;
	string denumire;
	string profesor;
	
public:
	Curs(int cod, string denumire, string profesor) {
		this->cod = cod;
		this->denumire = denumire;
		this->profesor = profesor;
	}

	Curs() {
		this->cod = 0;
		this->denumire = "";
		this->profesor = "";
	}

	int getCod() {	return this->cod; }
	void setCod(int cod) { this->cod = cod; }

	string getDenumire() {	return this->denumire;	}
	void setDenumire(string denumire) {	this->denumire = denumire;	}

	string getProfesor() { return this->profesor; }
	void setProfesor(string profesor) { this->profesor = profesor; }

	void AfisareCurs() {
		cout << "Cod: " << this->cod << " | Denumire: " << this->denumire << " | Profesor: " << this->profesor << endl;
	}
};

class Student : public Persoana{
private:
	int id;
	string facultate;
	vector<Curs> listaCursuri;
	vector<int> note;
public:
	Student(string nume, string prenume, string email, int id, string facultate, vector<Curs> cursuri, vector<int> note) : Persoana(nume, prenume, email) {
		this->id = id;
		this->facultate = facultate;
		this->listaCursuri = cursuri;
		this->note = note;
	}

	int getId() {
		return this->id;
	}

	void setId(int id) {
		this->id = id;
	}

	string getFacultate() {
		return this->facultate;
	}

	void setFacultate(string facultate) {
		this->facultate = facultate;
	}

	void setCursuri(vector<Curs> listaCursuri) {
		this->listaCursuri = listaCursuri;
	}

	void setNote(vector<int> note) {
		this->note = note;
	}
	Student(){
		this->id = 0;
	}
	float calculeazaMedie() {
		float suma = 0;
		for (int i = 0; i < note.size(); i++)
			suma += note[i];
		return suma / note.size();
	}

	void getRestante() {
		cout << this->prenume << " " << " Restante: ";
		for (int i = 0; i < note.size(); i++)
			if (note[i] < 5)
				cout << listaCursuri[i].getDenumire() << " ";
		cout << endl;
	}
};

int main() {
	//citire fisier text cursuri
	ifstream f("cursuri.txt");
	vector<Curs> cursuri;
	string linie;
	while (getline(f, linie)) {
		stringstream ss(linie);
		string cod_str, denumire, numeProf;
		int cod;
		Curs curs;
		getline(ss, cod_str, ',');
		cod = stoi(cod_str); curs.setCod(cod);
		getline(ss, denumire, ','); curs.setDenumire(denumire);
		getline(ss, numeProf, ','); curs.setProfesor(numeProf);
		cursuri.push_back(curs);
	}
	for (int i = 0; i < cursuri.size(); i++)
		cursuri[i].AfisareCurs();
	//f.close();
	//citire fisier text studenti

	/*
	ifstream f2("studenti.txt");
	vector<Student> studenti;
	while (getline(f2, linie)) {
		stringstream ss(linie);
		string nume, prenume, email, id_str, facultate, materii_str, note_str;
		int id;
		Student s;
		getline(ss, nume, ','); s.setNume(nume);
		getline(ss, prenume, ','); s.setPrenume(prenume);
		getline(ss, email, ','); s.setEmail(email);
		getline(ss, id_str, ','); 
		id = stoi(id_str); s.setId(id);
		getline(ss, facultate, ','); s.setFacultate(facultate);

		getline(ss, materii_str, ',');
		string temp = materii_str.substr(1, materii_str.size() - 2);
		stringstream valori(temp);
		string val;
		vector<int>rezultat;
		while (getline(valori, val, ','))
			rezultat.push_back(stoi(val));
		vector<Curs> materii;
		for (int i = 0; i < rezultat.size(); i++)
			materii.push_back(cursuri[rezultat[i]]);
		s.setCursuri(materii);

		getline(ss, note_str, ',');
		string temp2 = note_str.substr(1, note_str.size() - 2);
		stringstream valori2(temp2);
		vector<int> rezultat2;
		while (getline(valori2, val, ','))
			rezultat2.push_back(stoi(val));
		s.setNote(rezultat2);
		studenti.push_back(s);
	}
	for (int i = 0; i < studenti.size(); i++)
		studenti[i].Afisare();
	f2.close();
	*/
}