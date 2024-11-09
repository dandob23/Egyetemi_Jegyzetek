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
