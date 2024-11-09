//npx cypress open

describe('Basic Auth Tests', () => {
    
    it('Should display the welcome message for valid credentials', () => {
        cy.visit('https://the-internet.herokuapp.com/basic_auth', {
            auth: { username: 'admin', password: 'admin' }
        });
        cy.contains('Congratulations! You must have the proper credentials.').should('be.visible');
    });

    it('Should show Not authorized if canceled', () => {
        cy.visit('https://admin:wrongpass@the-internet.herokuapp.com/basic_auth', { failOnStatusCode: false });
        cy.contains('Not authorized').should('be.visible');
    });

});

describe('Checkboxes Tests', () => {
    it('Should load the Checkboxes page', () => {
        cy.visit('https://the-internet.herokuapp.com/checkboxes');
        cy.contains('Checkboxes').should('be.visible');
    });

    it('Should verify that there are 2 checkboxes', () => {
        cy.visit('https://the-internet.herokuapp.com/checkboxes');
        cy.get('input[type="checkbox"]').should('have.length', 2);
    });

    it('Should check that the second checkbox is checked by default', () => {
        cy.visit('https://the-internet.herokuapp.com/checkboxes');
        cy.get('input[type="checkbox"]').eq(1).should('be.checked');
    });

    it('Should check the first checkbox', () => {
        cy.visit('https://the-internet.herokuapp.com/checkboxes');
        cy.get('input[type="checkbox"]').first().check().should('be.checked');
    });

    it('Should uncheck the second checkbox', () => {
        cy.visit('https://the-internet.herokuapp.com/checkboxes');
        cy.get('input[type="checkbox"]').eq(1).uncheck().should('not.be.checked');
    });

});

describe('Dropdown List Tests', () => {
    it('Should load the Dropdown List page and verify dropdown functionality', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.contains('Dropdown List').should('be.visible');
    });

    it('Should verify that no option is selected by default', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.get('#dropdown').should('have.value', null);
    });

    it('Should select Option 1 from the dropdown', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.get('#dropdown').select('Option 1').should('have.value', '1');
    });

    it('Should select Option 2 from the dropdown', () => {
        cy.visit('https://the-internet.herokuapp.com/dropdown');
        cy.get('#dropdown').select('Option 2').should('have.value', '2');
    });
});

describe('File Download Tests', () => {
    it('Should load the File Download page and verify the page title', () => {
        cy.visit('https://the-internet.herokuapp.com/download');
        cy.contains('File Download').should('be.visible');
    });

    it('Should download hello.txt', () => {
        cy.visit('https://the-internet.herokuapp.com/download');
        cy.get('a').contains('hello.txt').click();
    });

    it('Should download selenium-snapshot.png', () => {
        cy.visit('https://the-internet.herokuapp.com/download');
        cy.get('a').contains('selenium-snapshot.png').click();
    });
});

describe('Inputs Tests', () => {
    it('Should load the Inputs page and verify the page title', () => {
        cy.visit('https://the-internet.herokuapp.com/inputs');
        cy.contains('Inputs').should('be.visible');
    });

    it('Should type a number in the input field', () => {
        cy.visit('https://the-internet.herokuapp.com/inputs');
        cy.get('input[type="number"]').type('5').should('have.value', '5');
    });
});

describe('Key Presses Tests', () => {

    it('Should load the Key Presses page and verify the page title', () => {
        cy.visit('https://the-internet.herokuapp.com/key_presses');
        cy.contains('Key Presses').should('be.visible');
    });

    it('Should verify the functionality for pressing the letter A', () => {
        cy.visit('https://the-internet.herokuapp.com/key_presses');
        cy.get('#target').type('a');
        cy.contains('You entered: A').should('be.visible');
    });

    it('Should verify the functionality for pressing the number 1', () => {
        cy.visit('https://the-internet.herokuapp.com/key_presses');
        cy.get('#target').type('1');
        cy.contains('You entered: 1').should('be.visible');
    });

    it('Should verify the functionality for pressing the slash key', () => {
        cy.visit('https://the-internet.herokuapp.com/key_presses');
        cy.get('#target').type('/');
        cy.contains('You entered: SLASH').should('be.visible');
    });
    
});

describe('Status Codes Tests', () => {
    it('Should load the Status Codes page and verify status codes', () => {
        cy.visit('https://the-internet.herokuapp.com/status_codes');
        cy.contains('Status Codes').should('be.visible');
        cy.get('a').contains('200').click();
        cy.contains('This page returned a 200 status code.').should('be.visible');
    });

    it('Should load the Status Codes page and verify status codes', () => {
        cy.visit('https://the-internet.herokuapp.com/status_codes');
        cy.get('a').contains('301').click();
        cy.contains('This page returned a 301 status code.').should('be.visible');
    });


    it('Should load the Status Codes page and verify status codes', () => {
        cy.visit('https://the-internet.herokuapp.com/status_codes');
        cy.get('a').contains('404').click();
        cy.contains('This page returned a 404 status code.').should('be.visible');
    });
    
    it('Should load the Status Codes page and verify status codes', () => {
        cy.visit('https://the-internet.herokuapp.com/status_codes');
        cy.get('a').contains('500').click();
        cy.contains('This page returned a 500 status code.').should('be.visible');
    });
});
