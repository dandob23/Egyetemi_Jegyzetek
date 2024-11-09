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
