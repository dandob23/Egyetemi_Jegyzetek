describe('File Download Tests', () => {
    it('Should load the File Download page and verify the page title', () => {
        cy.visit('https://the-internet.herokuapp.com/download');
        cy.contains('File Download').should('be.visible');
    });

    it('Should download test.jpg', () => {
        cy.visit('https://the-internet.herokuapp.com/download');
        cy.get('a').contains('test.jpg').click();
    });

    it('Should download empty.txt', () => {
        cy.visit('https://the-internet.herokuapp.com/download');
        cy.get('a').contains('empty.txt').click();
    });
});