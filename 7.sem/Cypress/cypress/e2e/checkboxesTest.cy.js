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